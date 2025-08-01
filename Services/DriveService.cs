
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Upload;
using Microsoft.Extensions.Options;
using SanAndres_Api.Helpers;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Services
{
  public class DriveDevService : IDriveDevService
  {
    private string _cachedFolderId;
    private readonly DriveSettings _settings;

    public DriveDevService(IOptions<DriveSettings> settings)
    {
      _settings = settings.Value;
    }

    private DriveService GetDriveServiceAsync()
    {
      GoogleCredential credential;
      using (var stream = new FileStream("drive_client.json", FileMode.Open, FileAccess.Read))
      {
        credential = GoogleCredential.FromStream(stream)
          .CreateScoped(DriveService.Scope.Drive);
      }

      return new DriveService(new BaseClientService.Initializer()
      {
        HttpClientInitializer = credential,
        ApplicationName = "AssessorCorp"
      });
    }

    public async Task<string> UploadToGoogleDrive(IFormFile file, string folderName = null)
    {
      if (file == null || file.Length == 0)
          throw new ArgumentException("Archivo inválido");

      var service = GetDriveServiceAsync();
      string folderId = await GetOrCreateFolderAsync(service, folderName ?? _settings.FolderName);

      var fileMetadata = new Google.Apis.Drive.v3.Data.File()
      {
        Name = file.FileName,
        Parents = new List<string> { folderId }
      };

      using (var stream = file.OpenReadStream())
      {
        var request = service.Files.Create(fileMetadata, stream, file.ContentType);
        request.SupportsAllDrives = true;
        request.ChunkSize = ResumableUpload.MinimumChunkSize * 2;

        // Agregamos logger de progreso
        request.ProgressChanged += progress => 
        {
          Console.WriteLine($"[{DateTime.UtcNow}] Progreso: {progress.Status} - {progress.BytesSent} bytes enviados");
        };

        var uploadResult = await request.UploadAsync();
        
        if (uploadResult.Status != UploadStatus.Completed)
            throw new DriveUploadException(uploadResult.Exception);

        var uploadedFile = request.ResponseBody;

        // Compartir automáticamente con el usuario
        await ShareFileWithUser(service, uploadedFile.Id);

        Console.WriteLine($"Archivo subido ID: {uploadedFile.Id}");
        return uploadedFile.Id;
      }
    }

    private async Task ShareFileWithUser(DriveService service, string fileId)
    {
      var permission = new Permission
      {
        Type = "anyone",
        Role = "reader",
      };

      try
      {
        await service.Permissions.Create(permission, fileId).ExecuteAsync();
        Console.WriteLine($"Archivo compartido");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error al compartir archivo: {ex.Message}");
        throw;
      }
    }

    private async Task<string> GetOrCreateFolderAsync(DriveService service, string folderName)
    {
      if (!string.IsNullOrEmpty(_cachedFolderId))
        return _cachedFolderId;

      // Buscar en el root del drive
      var listRequest = service.Files.List();
      listRequest.Q = $"mimeType='application/vnd.google-apps.folder' and name='{folderName}' and trashed=false and 'root' in parents";
      listRequest.Fields = "files(id, name)";
      
      var result = await listRequest.ExecuteAsync();
      
      if (result.Files.Count > 0)
      {
        _cachedFolderId = result.Files[0].Id;
        Console.WriteLine($"Usando carpeta existente ID: {_cachedFolderId}");
        return _cachedFolderId;
      }

      // Crear nueva carpeta en root
      var folderMetadata = new Google.Apis.Drive.v3.Data.File()
      {
        Name = folderName,
        MimeType = "application/vnd.google-apps.folder",
        Parents = new List<string> { "root" }
      };

      var request = service.Files.Create(folderMetadata);
      request.Fields = "id";
      
      var folder = await request.ExecuteAsync();
      _cachedFolderId = folder.Id;
      
      Console.WriteLine($"Carpeta creada ID: {_cachedFolderId}");

      return _cachedFolderId;
    }

    [Obsolete]
    public async Task<List<DriveFileSummaryDto>> GetFilesInFolderAsync()
    {
      var service = GetDriveServiceAsync();

      var listRequest = service.Files.List();
      listRequest.Q = "trashed = false";
      listRequest.Fields = "files(id, name, mimeType, createdTime, size)";
      listRequest.PageSize = 1000;

      var result = await listRequest.ExecuteAsync();
      return result.Files.Select(f => new DriveFileSummaryDto
      {
        Id = f.Id,
        MimeType = f.MimeType,
        CreatedTime = f.CreatedTime,
        CreatedTimeRaw = f.CreatedTimeRaw,
        CreatedTimeDateTimeOffset = f.CreatedTimeDateTimeOffset
      }).ToList();;
    }

    public async Task DeleteFileAsync(string fileId)
    {
      var service = GetDriveServiceAsync();
      var deleteRequest = service.Files.Delete(fileId);
      deleteRequest.SupportsAllDrives = true;
      await deleteRequest.ExecuteAsync();
      Console.WriteLine($"Archivo eliminado ID: {fileId}");
    }
  }

  public class DriveUploadException : Exception
  {
    public DriveUploadException(Exception innerException) 
      : base("Error al subir el archivo a Google Drive", innerException)
    {
    }
  }
}
