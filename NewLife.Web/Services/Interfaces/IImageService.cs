namespace NewLife.Web.Services.Interfaces
{
    public interface IImageService
    {
        Task<string> UploadImageAsync(IFormFile imageFile);

        Task ResizeImageAsync(string filePath, string uploadedFolder, string fileName);
    }
}
