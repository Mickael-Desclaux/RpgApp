using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IEquipmentService
    {
        public Task<IEnumerable<Equipment>> GetAllEquipmentAsync();
        public Task<Equipment> GetEquipmentByIdAsync(int equipmentId);
        public Task AddEquipmentAsync(Equipment equipment);
        public Task UpdateEquipmentAsync(Equipment equipment);
        public Task DeleteEquipmentAsync(Equipment equipment);
    }
}
