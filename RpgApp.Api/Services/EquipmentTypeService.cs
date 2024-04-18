using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class EquipmentTypeService(IRepository<EquipmentType> equipmentTypeRepository) : IEquipmentTypeService
    {
        public async Task<IEnumerable<EquipmentType>> GetAllEquipmentTypeAsync()
        {
            return await equipmentTypeRepository.GetAllAsync();
        }

        public async Task<EquipmentType> GetEquipmentTypeByIdAsync(int equipmentTypeId)
        {
            IEnumerable<EquipmentType> equipmentTypes = await equipmentTypeRepository.GetAllAsync();
            EquipmentType? equipmentType = equipmentTypes.FirstOrDefault(e => e.Id == equipmentTypeId);

            if (equipmentType == null)
            {
                throw new Exception("Ce type d'équipement n'existe pas.");
            }

            return equipmentType;
        }
    }
}
