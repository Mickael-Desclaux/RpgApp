using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface ICharacterResistanceService
    {
        public Task<IEnumerable<CharacterResistance>> GetAllCharacterResistanceAsync();
        public Task<CharacterResistance> GetCharacterResistanceByIdAsync(int characterResistanceId);
        public Task AddCharacterResistanceAsync(CharacterResistance characterResistance);
        public Task UpdateCharacterResistanceAsync(CharacterResistance characterResistance);
        public Task DeleteCharacterResistanceAsync(CharacterResistance characterResistance);
    }
}
