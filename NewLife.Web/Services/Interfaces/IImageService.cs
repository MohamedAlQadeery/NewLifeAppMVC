namespace NewLife.Web.Services.Interfaces
{
    public interface IImageService
    {
        Task<string> UploadImage(IFormFile imageFile);

        Task ResizeImage(string filePath, string uploadedFolder, string fileName);
    }
}
