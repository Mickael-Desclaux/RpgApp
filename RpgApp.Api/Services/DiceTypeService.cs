using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class DiceTypeService(IRepository<DiceType> diceTypeRepository) : IDiceTypeService
    {
        public async Task<IEnumerable<DiceType>> GetAllDiceTypeAsync()
        {
            return await diceTypeRepository.GetAllAsync();
        }

        public async Task<DiceType> GetDiceTypeByIdAsync(int diceTypeId)
        {
            IEnumerable<DiceType> diceTypes = await diceTypeRepository.GetAllAsync();
            DiceType? diceType = diceTypes.FirstOrDefault(d => d.Id == diceTypeId);

            if (diceType == null)
            {
                throw new Exception("Le type de dé n'existe pas.");
            }

            return diceType;
        }
    }
}
