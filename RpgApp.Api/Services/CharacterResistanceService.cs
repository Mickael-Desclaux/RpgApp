using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class CharacterResistanceService(IRepository<CharacterResistance> characterResistanceRepository) : ICharacterResistanceService
    {
        public async Task<IEnumerable<CharacterResistance>> GetAllCharacterResistanceAsync()
        {
            return await characterResistanceRepository.GetAllAsync();
        }

        public async Task<CharacterResistance> GetCharacterResistanceByIdAsync(int characterResistanceId)
        {
            IEnumerable<CharacterResistance> characterResistances = await characterResistanceRepository.GetAllAsync();
            CharacterResistance? characterResistance = characterResistances.FirstOrDefault(c => c.Id == characterResistanceId);

            if (characterResistance == null)
            {
                throw new Exception("Cette association de résistance n'existe pas.");
            }

            return characterResistance;
        }

        public async Task AddCharacterResistanceAsync(CharacterResistance characterResistance)
        {
            await characterResistanceRepository.AddAsync(characterResistance);
        }

        public async Task UpdateCharacterResistanceAsync(CharacterResistance characterResistance)
        {
            await characterResistanceRepository.UpdateAsync(characterResistance);
        }

        public async Task DeleteCharacterResistanceAsync(CharacterResistance characterResistance)
        {
            await characterResistanceRepository.DeleteAsync(characterResistance);
        }
    }
}
