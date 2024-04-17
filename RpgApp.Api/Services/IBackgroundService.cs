using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IBackgroundService
    {
        public Task<IEnumerable<Background>> GetAllBackgroundAsync();
        public Task<Background> GetBackgroundByIdAsync(int backgroundId);
        public Task AddBackgroundAsync(Background background);
        public Task UpdateBackgroundAsync(Background background);
        public Task DeleteBackgroundAsync(Background background);
    }
}
