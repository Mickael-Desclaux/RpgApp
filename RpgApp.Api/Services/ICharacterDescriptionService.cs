using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface ICharacterDescriptionService
    {
        public Task<IEnumerable<CharacterDescription>> GetAllCharacterDescriptionAsync();
        public Task<CharacterDescription> GetCharacterDescriptionByIdAsync(int characterDescriptionId);
        public Task AddCharacterDescriptionAsync(CharacterDescription characterDescription);
        public Task UpdateCharacterDescriptionAsync(CharacterDescription characterDescription);
        public Task DeleteCharacterDescriptionAsync(CharacterDescription characterDescription);
    }
}
