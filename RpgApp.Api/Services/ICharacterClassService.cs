using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface ICharacterClassService
    {
        public Task<IEnumerable<CharacterClass>> GetAllCharacterClassAsync();
        public Task<CharacterClass> GetCharacterClassByIdAsync (int characterClassId);
        public Task AddCharacterClassAsync(CharacterClass characterClass);
        public Task UpdateCharacterClassAsync(CharacterClass characterClass);
        public Task DeleteCharacterClassAsync (CharacterClass characterClass);
    }
}
