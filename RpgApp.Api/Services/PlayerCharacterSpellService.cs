using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class PlayerCharacterSpellService(IRepository<PlayerCharacterSpell> playerCharacterSpellRepository) : IPlayerCharacterSpellService
    {
        public async Task<IEnumerable<PlayerCharacterSpell>> GetAllPlayerCharacterSpellAsync()
        {
            return await playerCharacterSpellRepository.GetAllAsync();
        }

        public async Task<PlayerCharacterSpell> GetPlayerCharacterSpellByIdAsync(int playerCharacterSpellId)
        {
            IEnumerable<PlayerCharacterSpell> playerCharacterSpells = await playerCharacterSpellRepository.GetAllAsync();
            PlayerCharacterSpell? playerCharacterSpell = playerCharacterSpells.FirstOrDefault(p => p.Id == playerCharacterSpellId);

            if (playerCharacterSpell == null)
            {
                throw new Exception("Cette association sort / joueur n'existe pas.");
            }

            return playerCharacterSpell;
        }

        public async Task AddPlayerCharacterSpellAsync(PlayerCharacterSpell playerCharacterSpell)
        {
            await playerCharacterSpellRepository.AddAsync(playerCharacterSpell);
        }

        public async Task UpdatePlayerCharacterSpellAsync(PlayerCharacterSpell playerCharacterSpell)
        {
            await playerCharacterSpellRepository.UpdateAsync(playerCharacterSpell);
        }

        public async Task DeletePlayerCharacterSpellAsync(PlayerCharacterSpell playerCharacterSpell)
        {
            await playerCharacterSpellRepository.DeleteAsync(playerCharacterSpell);
        }
    }
}
