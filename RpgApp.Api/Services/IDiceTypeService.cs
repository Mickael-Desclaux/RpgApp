using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IDiceTypeService
    {
        public Task<IEnumerable<DiceType>> GetAllDiceTypeAsync();
        public Task<DiceType> GetDiceTypeByIdAsync(int diceTypeId);
    }
}
