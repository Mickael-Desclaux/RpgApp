using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IDamageResistanceService
    {
        public Task<IEnumerable<DamageResistance>> GetAllDamageResistanceAsync();
        public Task<DamageResistance> GetDamageResistanceByIdAsync(int damageResistanceId);
        public Task AddDamageResistanceAsync(DamageResistance damageResistance);
        public Task UpdateDamageResistanceAsync(DamageResistance damageResistance);
        public Task DeleteDamageResistanceAsync(DamageResistance damageResistance);
    }
}
