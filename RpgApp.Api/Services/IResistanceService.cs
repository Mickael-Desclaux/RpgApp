using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IResistanceService
    {
        public Task<IEnumerable<Resistance>> GetAllResistanceAsync();
        public Task<Resistance> GetResistanceByIdAsync(int resistanceId);
    }
}