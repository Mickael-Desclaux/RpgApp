using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IRaceService
    {
        public Task<IEnumerable<Race>> GetAllRaceAsync();
        public Task<Race> GetRaceByIdAsync(int raceId);
        public Task AddRaceAsync(Race race);
        public Task UpdateRaceAsync(Race race);
        public Task DeleteRaceAsync(Race race);
    }
}
