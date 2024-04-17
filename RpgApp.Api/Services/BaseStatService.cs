using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class BaseStatService(IRepository<BaseStat> baseStatRepository) : IBaseStatService
    {
        public async Task<IEnumerable<BaseStat>> GetAllBaseStatAsync()
        {
            return await baseStatRepository.GetAllAsync();
        }

        public async Task<BaseStat> GetBaseStatByIdAsync(int baseStatId)
        {
            IEnumerable<BaseStat> baseStats = await baseStatRepository.GetAllAsync();
            BaseStat? baseStat = baseStats.FirstOrDefault(b => b.Id == baseStatId);

            if (baseStat == null)
            {
                throw new Exception("Ces statistiques n'existent pas.");
            }

            return baseStat;
        }

        public async Task AddBaseStatAsync(BaseStat baseStat)
        {
            await baseStatRepository.AddAsync(baseStat);
        }

        public async Task UpdateBaseStatAsync(BaseStat baseStat)
        {
            await baseStatRepository.UpdateAsync(baseStat);
        }

        public async Task DeleteBaseStatAsync(BaseStat baseStat)
        {
            await baseStatRepository.DeleteAsync(baseStat);
        }
    }
}
