using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class ImageService(IRepository<Image> imageRepository) : IImageService
    {
        public async Task<Image> GetImageByIdAsync(int imageId)
        {
            IEnumerable<Image> images = await imageRepository.GetAllAsync();
            Image? image = images.FirstOrDefault(i => i.Id == imageId);

            if (image == null)
            {
                throw new Exception("Image non trouvée.");
            }

            return image;
        }

        public async Task AddImageAsync(Image image)
        {
            await imageRepository.AddAsync(image);
        }

        public async Task UpdateImageAsync(Image image)
        {
            await imageRepository.UpdateAsync(image);
        }

        public async Task DeleteImageAsync(Image image)
        {
            await imageRepository.DeleteAsync(image);
        }
    }
}
