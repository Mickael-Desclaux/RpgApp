using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IDamageTypeService
    {
        public Task<IEnumerable<DamageType>> GetAllDamageTypeAsync();
        public Task<DamageType> GetDamageTypeByIdAsync(int damageTypeId);
    }
}
