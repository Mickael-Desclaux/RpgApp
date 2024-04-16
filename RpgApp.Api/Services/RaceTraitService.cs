using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class RaceTraitService(IRepository<RaceTrait> raceTraitRepository) : IRaceTraitService
    {
        public async Task<IEnumerable<RaceTrait>> GetAllRaceTraitAsync()
        {
            return await raceTraitRepository.GetAllAsync();
        }

        public async Task<RaceTrait> GetRaceTraitByIdAsync(int raceTraitId)
        {
            IEnumerable<RaceTrait> raceTraits = await raceTraitRepository.GetAllAsync();
            RaceTrait? raceTrait = raceTraits.FirstOrDefault(r => r.Id == raceTraitId);

            if (raceTrait == null)
            {
                throw new Exception("Cette capacité de race n'existe pas.");
            }

            return raceTrait;
        }

        public async Task AddRaceTraitAsync(RaceTrait raceTrait)
        {
            await raceTraitRepository.AddAsync(raceTrait);
        }

        public async Task UpdateRaceTraitAsync(RaceTrait raceTrait)
        {
            await raceTraitRepository.UpdateAsync(raceTrait);
        }

        public async Task DeleteRaceTraitAsync(RaceTrait raceTrait)
        {
            await raceTraitRepository.DeleteAsync(raceTrait);
        }
    }
}
