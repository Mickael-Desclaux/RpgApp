using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class SavingStatService(IRepository<SavingStat> savingStatRepository) : ISavingStatService
    {
        public async Task<IEnumerable<SavingStat>> GetAllSavingStatAsync()
        {
            return await savingStatRepository.GetAllAsync();
        }

        public async Task<SavingStat> GetSavingStatByIdAsync(int savingStatId)
        {
            IEnumerable<SavingStat> savingStats = await savingStatRepository.GetAllAsync();
            SavingStat? savingStat = savingStats.FirstOrDefault(s => s.Id == savingStatId);

            if (savingStat == null)
            {
                throw new Exception("Ces statistiques de sauvegarde n'existent pas.");
            }

            return savingStat;
        }

        public async Task AddSavingStatAsync(SavingStat savingStat)
        {
            await savingStatRepository.AddAsync(savingStat);
        }

        public async Task UpdateSavingStatAsync(SavingStat savingStat)
        {
            await savingStatRepository.UpdateAsync(savingStat);
        }

        public async Task DeleteSavingStatAsync(SavingStat savingStat)
        {
            await savingStatRepository.DeleteAsync(savingStat);
        }
    }
}
