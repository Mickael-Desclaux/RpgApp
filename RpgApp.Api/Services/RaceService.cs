using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class RaceService(IRepository<Race> raceRepository) : IRaceService
    {
        public async Task<IEnumerable<Race>> GetAllRaceAsync()
        {
            return await raceRepository.GetAllAsync();
        }

        public async Task<Race> GetRaceByIdAsync(int raceId)
        {
            IEnumerable<Race> races = await raceRepository.GetAllAsync();
            Race? race = races.FirstOrDefault(r => r.Id == raceId);

            if (race == null)
            {
                throw new Exception("Cette race n'existe pas.");
            }

            return race;
        }

        public async Task AddRaceAsync(Race race)
        {
            await raceRepository.AddAsync(race);
        }

        public async Task UpdateRaceAsync(Race race)
        {
            await raceRepository.UpdateAsync(race);
        }

        public async Task DeleteRaceAsync(Race race)
        {
            await raceRepository.DeleteAsync(race);
        }
    }
}
