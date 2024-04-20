using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IPlayerCharacterFeatService
    {
        public Task<IEnumerable<PlayerCharacterFeat>> GetAllPlayerCharacterFeatAsync();
        public Task<PlayerCharacterFeat> GetPlayerCharacterFeatByIdAsync(int playerCharacterFeatId);
        public Task AddPlayerCharacterFeatAsync(PlayerCharacterFeat playerCharacterFeat);
        public Task UpdatePlayerCharacterFeatAsync(PlayerCharacterFeat playerCharacterFeat);
        public Task DeletePlayerCharacterFeatAsync(PlayerCharacterFeat playerCharacterFeat);
    }
}
