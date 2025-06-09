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
        
      var uploadResult = new RawUploadResult();

      var file = setFile;

      if (file.Length > 8000000)
      {
        return null;
      }

      using (var stream = file.OpenReadStream())
      {
          var uploadParams = new RawUploadParams()
          {
            File = new FileDescription(file.FileName, stream),
            PublicId = route
          };
          uploadResult = _cloudinary.Upload(uploadParams);
      }

      var Url =  uploadResult.SecureUrl.ToString();
      
      return  Url;
    }

  }
}