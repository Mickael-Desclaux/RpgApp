using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class PlayerCharacterFeatService(IRepository<PlayerCharacterFeat> playerCharacterFeatRepository) : IPlayerCharacterFeatService
    {
        public async Task<IEnumerable<PlayerCharacterFeat>> GetAllPlayerCharacterFeatAsync()
        {
            return await playerCharacterFeatRepository.GetAllAsync();
        }

        public async Task<PlayerCharacterFeat> GetPlayerCharacterFeatByIdAsync(int playerCharacterFeatId)
        {
            IEnumerable<PlayerCharacterFeat> playerCharacterFeats = await playerCharacterFeatRepository.GetAllAsync();
            PlayerCharacterFeat? playerCharacterFeat = playerCharacterFeats.FirstOrDefault(p => p.Id == playerCharacterFeatId);

            if (playerCharacterFeat == null)
            {
                throw new Exception("Cette association joueur / don n'existe pas.");
            }

            return playerCharacterFeat;
        }

        public async Task AddPlayerCharacterFeatAsync(PlayerCharacterFeat playerCharacterFeat)
        {
            await playerCharacterFeatRepository.AddAsync(playerCharacterFeat);
        }

        public async Task UpdatePlayerCharacterFeatAsync(PlayerCharacterFeat playerCharacterFeat)
        {
            await playerCharacterFeatRepository.UpdateAsync(playerCharacterFeat);
        }

        public async Task DeletePlayerCharacterFeatAsync(PlayerCharacterFeat playerCharacterFeat)
        {
            await playerCharacterFeatRepository.DeleteAsync(playerCharacterFeat);
        }
    }
}
