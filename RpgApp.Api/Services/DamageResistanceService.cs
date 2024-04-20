using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class DamageResistanceService(IRepository<DamageResistance> damageResistanceRepository) : IDamageResistanceService
    {
        public async Task<IEnumerable<DamageResistance>> GetAllDamageResistanceAsync()
        {
            return await damageResistanceRepository.GetAllAsync();
        }

        public async Task<DamageResistance> GetDamageResistanceByIdAsync(int damageResistanceId)
        {
            IEnumerable<DamageResistance> damageResistances = await damageResistanceRepository.GetAllAsync();
            DamageResistance? DamageResistance = damageResistances.FirstOrDefault(d => d.Id == damageResistanceId);

            if (DamageResistance == null)
            {
                throw new Exception("Cette association de résistance n'existe pas.");
            }

            return DamageResistance;
        }

        public async Task AddDamageResistanceAsync(DamageResistance damageResistance)
        {
            await damageResistanceRepository.AddAsync(damageResistance);
        }

        public async Task UpdateDamageResistanceAsync(DamageResistance damageResistance)
        {
            await damageResistanceRepository.UpdateAsync(damageResistance);
        }

        public async Task DeleteDamageResistanceAsync(DamageResistance damageResistance)
        {
            await damageResistanceRepository.DeleteAsync(damageResistance);
        }
    }
}
