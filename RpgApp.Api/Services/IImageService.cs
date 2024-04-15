using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IImageService
    {
        public Task<Image> GetImageByIdAsync(int imageId);
        public Task AddImageAsync(Image image);
        public Task UpdateImageAsync(Image image);
        public Task DeleteImageAsync(Image image);
    }
}
