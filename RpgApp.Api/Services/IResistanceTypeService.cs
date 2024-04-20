using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IResistanceTypeService
    {
        public Task<IEnumerable<ResistanceType>> GetAllResistanceTypeAsync();
        public Task<ResistanceType> GetResistanceTypeByIdAsync(int resistanceTypeId);
    }
}
