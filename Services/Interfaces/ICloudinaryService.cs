namespace SanAndres_Api.Services.Interfaces
{
    public interface ICloudinaryService
    {
        string UploadFile(IFormFile  setFile, string route);
    }
}