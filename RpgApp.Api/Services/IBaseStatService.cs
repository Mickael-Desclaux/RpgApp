using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IBaseStatService
    {
        public Task<IEnumerable<BaseStat>> GetAllBaseStatAsync();
        public Task<BaseStat> GetBaseStatByIdAsync(int baseStatId);
        public Task AddBaseStatAsync(BaseStat baseStat);
        public Task UpdateBaseStatAsync(BaseStat baseStat);
        public Task DeleteBaseStatAsync(BaseStat baseStat);
    }
}
