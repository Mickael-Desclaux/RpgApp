using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IPlayerCharacterService
    {
        public Task<IEnumerable<PlayerCharacter>> GetAllPlayerCharacterAsync();
        public Task<PlayerCharacter> GetPlayerCharacterByIdAsync(int playerCharacterId);
        public Task AddPlayerCharacterAsync(PlayerCharacter playerCharacter);
        public Task UpdatePlayerCharacterAsync(PlayerCharacter playerCharacter);
        public Task DeletePlayerCharacterAsync(PlayerCharacter playerCharacter);
    }
}
