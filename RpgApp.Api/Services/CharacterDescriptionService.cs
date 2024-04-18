using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class CharacterDescriptionService(IRepository<CharacterDescription> characterDescriptionRepository) : ICharacterDescriptionService
    {
        public async Task<IEnumerable<CharacterDescription>> GetAllCharacterDescriptionAsync()
        {
            return await characterDescriptionRepository.GetAllAsync();
        }

        public async Task<CharacterDescription> GetCharacterDescriptionByIdAsync(int characterDescriptionId)
        {
            IEnumerable<CharacterDescription> characterDescriptions = await characterDescriptionRepository.GetAllAsync();
            CharacterDescription? characterDescription = characterDescriptions.FirstOrDefault(c => c.Id == characterDescriptionId);

            if (characterDescription == null)
            {
                throw new Exception("Cette description de personnage n'existe pas.");
            }

            return characterDescription;
        }

        public async Task AddCharacterDescriptionAsync(CharacterDescription characterDescription)
        {
            await characterDescriptionRepository.AddAsync(characterDescription);
        }

        public async Task UpdateCharacterDescriptionAsync(CharacterDescription characterDescription)
        {
            await characterDescriptionRepository.UpdateAsync(characterDescription);
        }

        public async Task DeleteCharacterDescriptionAsync(CharacterDescription characterDescription)
        {
            await characterDescriptionRepository.DeleteAsync(characterDescription);
        }
    }
}
