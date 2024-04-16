using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class FeatService(IRepository<Feat> featRepository) : IFeatService
    {
        public async Task<IEnumerable<Feat>> GetAllFeatAsync()
        {
            return await featRepository.GetAllAsync();
        }

        public async Task<Feat> GetFeatByIdAsync(int featId)
        {
            IEnumerable<Feat> feats = await featRepository.GetAllAsync();
            Feat? feat = feats.FirstOrDefault(f => f.Id == featId);

            if (feat == null)
            {
                throw new Exception("Le don n'existe pas.");
            }

            return feat;
        }

        public async Task AddFeatAsync(Feat feat)
        {
            await featRepository.AddAsync(feat);
        }

        public async Task UpdateFeatAsync(Feat feat)
        {
            await featRepository.UpdateAsync(feat);
        }

        public async Task DeleteFeatAsync(Feat feat)
        {
            await featRepository.DeleteAsync(feat);
        }
    }
}
