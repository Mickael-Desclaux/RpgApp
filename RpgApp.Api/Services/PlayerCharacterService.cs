using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class PlayerCharacterService(IRepository<PlayerCharacter> playerCharacterRepository) : IPlayerCharacterService
    {
        public async Task<IEnumerable<PlayerCharacter>> GetAllPlayerCharacterAsync()
        {
            return await playerCharacterRepository.GetAllAsync();
        }

        public async Task<PlayerCharacter> GetPlayerCharacterByIdAsync(int playerCharacterId)
        {
            IEnumerable<PlayerCharacter> playerCharacters = await playerCharacterRepository.GetAllAsync();
            PlayerCharacter? playerCharacter = playerCharacters.FirstOrDefault(p => p.Id == playerCharacterId);

            if (playerCharacter == null)
            {
                throw new Exception("Le personnage n'existe pas.");
            }

            return playerCharacter;
        }

        public async Task AddPlayerCharacterAsync(PlayerCharacter playerCharacter)
        {
            await playerCharacterRepository.AddAsync(playerCharacter);
        }

        public async Task UpdatePlayerCharacterAsync(PlayerCharacter playerCharacter)
        {
            await playerCharacterRepository.UpdateAsync(playerCharacter);
        }

        public async Task DeletePlayerCharacterAsync(PlayerCharacter playerCharacter)
        {
            await playerCharacterRepository.DeleteAsync(playerCharacter);
        }
    }
}
