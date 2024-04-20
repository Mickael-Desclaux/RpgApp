using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IMonsterLanguageService
    {
        public Task<IEnumerable<MonsterLanguage>> GetAllMonsterLanguageAsync();
        public Task<MonsterLanguage> GetMonsterLanguageByIdAsync(int monsterLanguageId);
        public Task AddMonsterLanguageAsync(MonsterLanguage monsterLanguage);
        public Task UpdateMonsterLanguageAsync(MonsterLanguage monsterLanguage);
        public Task DeleteMonsterLanguageAsync(MonsterLanguage monsterLanguage);
    }
}
