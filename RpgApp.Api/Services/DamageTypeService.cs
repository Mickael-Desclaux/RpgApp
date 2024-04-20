using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class DamageTypeService(IRepository<DamageType> damageTypeRepository) : IDamageTypeService
    {
        public async Task<IEnumerable<DamageType>> GetAllDamageTypeAsync()
        {
            return await damageTypeRepository.GetAllAsync();
        }

        public async Task<DamageType> GetDamageTypeByIdAsync(int damageTypeId)
        {
            IEnumerable<DamageType> damageTypes = await damageTypeRepository.GetAllAsync();
            DamageType? damageType = damageTypes.FirstOrDefault(d => d.Id == damageTypeId);

            if (damageType == null)
            {
                throw new Exception("Ce type de dégât n'existe pas.");
            }

            return damageType;
        }
    }
}
