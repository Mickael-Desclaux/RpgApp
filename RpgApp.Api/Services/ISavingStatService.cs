using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface ISavingStatService
    {
        public Task<IEnumerable<SavingStat>> GetAllSavingStatAsync();
        public Task<SavingStat> GetSavingStatByIdAsync(int savingStatId);
        public Task AddSavingStatAsync(SavingStat savingStat);
        public Task UpdateSavingStatAsync(SavingStat savingStat);
        public Task DeleteSavingStatAsync(SavingStat savingStat);
    }
}
