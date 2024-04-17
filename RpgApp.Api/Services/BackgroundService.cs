using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class BackgroundService(IRepository<Background> backgroundRepository) : IBackgroundService
    {
        public async Task<IEnumerable<Background>> GetAllBackgroundAsync()
        {
            return await backgroundRepository.GetAllAsync();
        }

        public async Task<Background> GetBackgroundByIdAsync(int backgroundId)
        {
            IEnumerable<Background> backgrounds = await backgroundRepository.GetAllAsync();
            Background? background = backgrounds.FirstOrDefault(b => b.Id == backgroundId);

            if (background == null)
            {
                throw new Exception("Cet historique n'existe pas.");
            }

            return background;
        }

        public async Task AddBackgroundAsync(Background background)
        {
            await backgroundRepository.AddAsync(background);
        }

        public async Task UpdateBackgroundAsync(Background background)
        {
            await backgroundRepository.UpdateAsync(background);
        }

        public async Task DeleteBackgroundAsync(Background background)
        {
            await backgroundRepository.DeleteAsync(background);
        }
    }
}
