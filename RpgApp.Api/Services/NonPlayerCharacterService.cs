using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class NonPlayerCharacterService(IRepository<NonPlayerCharacter> nonPlayerCharacterRepository) : INonPlayerCharacterService
    {
        public async Task<IEnumerable<NonPlayerCharacter>> GetAllNonPlayerCharacterAsync()
        {
            return await nonPlayerCharacterRepository.GetAllAsync();
        }

        public async Task<NonPlayerCharacter> GetNonPlayerCharacterByIdAsync(int nonPlayerCharacterId)
        {
            IEnumerable<NonPlayerCharacter> nonPlayerCharacters = await nonPlayerCharacterRepository.GetAllAsync();
            NonPlayerCharacter? nonPlayerCharacter = nonPlayerCharacters.FirstOrDefault(n => n.Id == nonPlayerCharacterId);

            if (nonPlayerCharacter == null)
            {
                throw new Exception("Ce NPC n'existe pas.");
            }

            return nonPlayerCharacter;
        }

        public async Task AddNonPlayerCharacterAsync(NonPlayerCharacter nonPlayerCharacter)
        {
            await nonPlayerCharacterRepository.AddAsync(nonPlayerCharacter);
        }

        public async Task UpdateNonPlayerCharacterAsync(NonPlayerCharacter nonPlayerCharacter)
        {
            await nonPlayerCharacterRepository.UpdateAsync(nonPlayerCharacter);
        }

        public async Task DeleteNonPlayerCharacterAsync(NonPlayerCharacter nonPlayerCharacter)
        {
            await nonPlayerCharacterRepository.DeleteAsync(nonPlayerCharacter);
        }
    }
}
