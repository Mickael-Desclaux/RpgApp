using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IRaceTraitService
    {
        public Task<IEnumerable<RaceTrait>> GetAllRaceTraitAsync();
        public Task<RaceTrait> GetRaceTraitByIdAsync(int raceTraitId);
        public Task AddRaceTraitAsync(RaceTrait raceTrait);
        public Task UpdateRaceTraitAsync(RaceTrait raceTrait);
        public Task DeleteRaceTraitAsync(RaceTrait raceTrait);
    }
}
