using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class ResistanceTypeService(IRepository<ResistanceType> resistanceTypeRepository) : IResistanceTypeService
    {
        public async Task<IEnumerable<ResistanceType>> GetAllResistanceTypeAsync()
        {
            return await resistanceTypeRepository.GetAllAsync();
        }

        public async Task<ResistanceType> GetResistanceTypeByIdAsync(int resistanceTypeId)
        {
            IEnumerable<ResistanceType> resistanceTypes = await resistanceTypeRepository.GetAllAsync();
            ResistanceType? resistanceType = resistanceTypes.FirstOrDefault(r => r.Id == resistanceTypeId);

            if (resistanceType == null)
            {
                throw new Exception("Ce type de résistance n'existe pas.");
            }

            return resistanceType;
        }
    }
}
