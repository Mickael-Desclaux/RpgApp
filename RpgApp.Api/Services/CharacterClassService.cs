using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class CharacterClassService(IRepository<CharacterClass> characterClassRepository) : ICharacterClassService
    {
        public async Task<IEnumerable<CharacterClass>> GetAllCharacterClassAsync()
        {
            return await characterClassRepository.GetAllAsync();
        }

        public async Task<CharacterClass> GetCharacterClassByIdAsync(int characterClassId)
        {
            IEnumerable<CharacterClass> characterClasses = await characterClassRepository.GetAllAsync();
            CharacterClass? characterClass = characterClasses.FirstOrDefault(c => c.Id == characterClassId);

            if (characterClass == null)
            {
                throw new Exception("Cette classe n'existe pas.");
            }

            return characterClass;
        }

        public async Task AddCharacterClassAsync(CharacterClass characterClass)
        {
            await characterClassRepository.AddAsync(characterClass);
        }

        public async Task UpdateCharacterClassAsync(CharacterClass characterClass)
        {
            await characterClassRepository.UpdateAsync(characterClass);
        }

        public async Task DeleteCharacterClassAsync(CharacterClass characterClass)
        {
            await characterClassRepository.DeleteAsync(characterClass);
        }
    }
}
