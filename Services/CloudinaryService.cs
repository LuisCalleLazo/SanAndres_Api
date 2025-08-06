using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Options;
using SanAndres_Api.Helpers;
using SanAndres_Api.Services.Interfaces;
namespace usr_service.Services
{
  public class CloudinaryService : ICloudinaryService
  {
    private readonly IOptions<CloudinarySetting> _cloudinaryConfig;
    private Cloudinary _cloudinary;

    public CloudinaryService(IOptions<CloudinarySetting> cloudinaryConfig)
    {
      _cloudinaryConfig = cloudinaryConfig;
      Account acc = new Account(
        _cloudinaryConfig.Value.CloudName,
        _cloudinaryConfig.Value.ApiKey,
        _cloudinaryConfig.Value.ApiSecret
      );

      _cloudinary = new Cloudinary(acc);
    }

    public string UploadFile(IFormFile setFile, string route)
    {
      if (setFile == null || setFile.Length == 0)
      {
        throw new InvalidOperationException("Not Exist File");
      }

      if (_cloudinaryConfig?.Value == null)
      {
        throw new InvalidOperationException("Cloudinary configuration is missing.");
      }

      if (setFile.Length > 30000000) // 30MB
      {
        return null;
      }

      try
      {
        using var stream = setFile.OpenReadStream();
        var uploadParams = new RawUploadParams()
        {
          File = new FileDescription(setFile.FileName, stream),
          PublicId = route
        };

        var uploadResult = _cloudinary.Upload(uploadParams);

        if (uploadResult == null)
        {
          throw new InvalidOperationException("Cloudinary upload failed - no result returned");
        }

        if (uploadResult.Error != null)
        {
          throw new InvalidOperationException($"Cloudinary upload error: {uploadResult.Error.Message}");
        }

        if (uploadResult.SecureUrl == null)
        {
          throw new InvalidOperationException("Cloudinary upload succeeded but no SecureUrl was returned");
        }

        return uploadResult.SecureUrl.ToString();
      }
      catch (Exception ex)
      {
        // Log the exception details here
        throw new InvalidOperationException("Failed to upload file to Cloudinary", ex);
      }
    }
  }
}