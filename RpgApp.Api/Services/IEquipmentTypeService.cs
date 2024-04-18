using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IEquipmentTypeService
    {
        public Task<IEnumerable<EquipmentType>> GetAllEquipmentTypeAsync();
        public Task<EquipmentType> GetEquipmentTypeByIdAsync(int equipmentTypeId);
    }
}
