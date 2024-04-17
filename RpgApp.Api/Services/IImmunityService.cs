using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IImmunityService
    {
        public Task<IEnumerable<Immunity>> GetAllImmunityAsync();
        public Task<Immunity> GetImmunityByIdAsync(int immunityId);
    }
}
