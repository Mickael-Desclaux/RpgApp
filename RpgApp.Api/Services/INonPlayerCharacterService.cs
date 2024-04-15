using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface INonPlayerCharacterService
    {
        public Task<IEnumerable<NonPlayerCharacter>> GetAllNonPlayerCharacterAsync();
        public Task<NonPlayerCharacter> GetNonPlayerCharacterByIdAsync(int nonPlayerCharacterId);
        public Task AddNonPlayerCharacterAsync(NonPlayerCharacter nonPlayerCharacter);
        public Task UpdateNonPlayerCharacterAsync(NonPlayerCharacter nonPlayerCharacter);
        public Task DeleteNonPlayerCharacterAsync(NonPlayerCharacter nonPlayerCharacter);
    }
}
