using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class PlayerCharacterLanguageService(IRepository<PlayerCharacterLanguage> playerCharacterLanguageRepository) : IPlayerCharacterLanguageService
    {
        public async Task<IEnumerable<PlayerCharacterLanguage>> GetAllPlayerCharacterLanguageAsync()
        {
            return await playerCharacterLanguageRepository.GetAllAsync();
        }

        public async Task<PlayerCharacterLanguage> GetPlayerCharacterLanguageByIdAsync(int playerCharacterLanguageId)
        {
            IEnumerable<PlayerCharacterLanguage> playerCharacterLanguages = await playerCharacterLanguageRepository.GetAllAsync();
            PlayerCharacterLanguage? playerCharacterLanguage = playerCharacterLanguages.FirstOrDefault(p => p.Id == playerCharacterLanguageId);

            if (playerCharacterLanguage == null)
            {
                throw new Exception("L'association joueur / langage n'existe pas.");
            }

            return playerCharacterLanguage;
        }

        public async Task AddPlayerCharacterLanguageAsync(PlayerCharacterLanguage playerCharacterLanguage)
        {
            await playerCharacterLanguageRepository.AddAsync(playerCharacterLanguage);
        }

        public async Task UpdatePlayerCharacterLanguageAsync(PlayerCharacterLanguage playerCharacterLanguage)
        {
            await playerCharacterLanguageRepository.UpdateAsync(playerCharacterLanguage);
        }

        public async Task DeletePlayerCharacterLanguageAsync(PlayerCharacterLanguage playerCharacterLanguage)
        {
            await playerCharacterLanguageRepository.DeleteAsync(playerCharacterLanguage);
        }
    }
}
