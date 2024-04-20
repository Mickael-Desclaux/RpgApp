using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IPlayerCharacterLanguageService
    {
        public Task<IEnumerable<PlayerCharacterLanguage>> GetAllPlayerCharacterLanguageAsync();
        public Task<PlayerCharacterLanguage> GetPlayerCharacterLanguageByIdAsync(int playerCharacterLanguageId);
        public Task AddPlayerCharacterLanguageAsync(PlayerCharacterLanguage playerCharacterLanguage);
        public Task UpdatePlayerCharacterLanguageAsync(PlayerCharacterLanguage playerCharacterLanguage);
        public Task DeletePlayerCharacterLanguageAsync(PlayerCharacterLanguage playerCharacterLanguage);
    }
}
