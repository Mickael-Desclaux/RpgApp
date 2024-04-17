using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class ImmunityService(IRepository<Immunity> immunityRepository) : IImmunityService
    {
        public async Task<IEnumerable<Immunity>> GetAllImmunityAsync()
        {
            return await immunityRepository.GetAllAsync();
        }

        public async Task<Immunity> GetImmunityByIdAsync(int immunityId)
        {
            IEnumerable<Immunity> immunities = await immunityRepository.GetAllAsync();
            Immunity? immunity = immunities.FirstOrDefault(i => i.Id == immunityId);

            if (immunity == null)
            {
                throw new Exception("Cette immunité n'existe pas.");
            }

            return immunity;
        }
    }
}
