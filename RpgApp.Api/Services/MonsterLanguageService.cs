using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class MonsterLanguageService(IRepository<MonsterLanguage> monsterLanguageRepository) : IMonsterLanguageService
    {
        public async Task<IEnumerable<MonsterLanguage>> GetAllMonsterLanguageAsync()
        {
            return await monsterLanguageRepository.GetAllAsync();
        }

        public async Task<MonsterLanguage> GetMonsterLanguageByIdAsync(int monsterLanguageId)
        {
            IEnumerable<MonsterLanguage> monsterLanguages = await monsterLanguageRepository.GetAllAsync();
            MonsterLanguage? monsterLanguage = monsterLanguages.FirstOrDefault(m => m.Id == monsterLanguageId);

            if (monsterLanguage == null)
            {
                throw new Exception("L'association monstre / langage n'existe pas.");
            }

            return monsterLanguage;
        }

        public async Task AddMonsterLanguageAsync(MonsterLanguage monsterLanguage)
        {
            await monsterLanguageRepository.AddAsync(monsterLanguage);
        }

        public async Task UpdateMonsterLanguageAsync(MonsterLanguage monsterLanguage)
        {
            await monsterLanguageRepository.UpdateAsync(monsterLanguage);
        }

        public async Task DeleteMonsterLanguageAsync(MonsterLanguage monsterLanguage)
        {
            await monsterLanguageRepository.DeleteAsync(monsterLanguage);
        }
    }
}
