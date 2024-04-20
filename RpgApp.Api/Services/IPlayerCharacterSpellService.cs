using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IPlayerCharacterSpellService
    {
        public Task<IEnumerable<PlayerCharacterSpell>> GetAllPlayerCharacterSpellAsync();
        public Task<PlayerCharacterSpell> GetPlayerCharacterSpellByIdAsync(int playerCharacterPlayerCharacterSpellId);
        public Task AddPlayerCharacterSpellAsync(PlayerCharacterSpell playerCharacterPlayerCharacterSpell);
        public Task UpdatePlayerCharacterSpellAsync(PlayerCharacterSpell playerCharacterPlayerCharacterSpell);
        public Task DeletePlayerCharacterSpellAsync(PlayerCharacterSpell playerCharacterPlayerCharacterSpell);
    }
}
