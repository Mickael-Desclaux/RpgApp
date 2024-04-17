using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class EquipmentService(IRepository<Equipment> equipmentRepository) : IEquipmentService
    {
        public async Task<IEnumerable<Equipment>> GetAllEquipmentAsync()
        {
            return await equipmentRepository.GetAllAsync();
        }

        public async Task<Equipment> GetEquipmentByIdAsync(int equipmentId)
        {
            IEnumerable<Equipment> equipments = await equipmentRepository.GetAllAsync();
            Equipment? equipment = equipments.FirstOrDefault(e => e.Id == equipmentId);

            if (equipment == null)
            {
                throw new Exception("Cet équipement n'existe pas.");
            }

            return equipment;
        }

        public async Task AddEquipmentAsync(Equipment equipment)
        {
            await equipmentRepository.AddAsync(equipment);
        }

        public async Task UpdateEquipmentAsync(Equipment equipment)
        {
            await equipmentRepository.UpdateAsync(equipment);
        }

        public async Task DeleteEquipmentAsync(Equipment equipment)
        {
            await equipmentRepository.DeleteAsync(equipment);
        }
    }
}
