using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IMonsterPassiveSkillService
    {
        public Task<IEnumerable<MonsterPassiveSkill>> GetAllMonsterPassiveSkillAsync();
        public Task<MonsterPassiveSkill> GetMonsterPassiveSkillByIdAsync(int monsterPassiveSkillId);
        public Task AddMonsterPassiveSkillAsync(MonsterPassiveSkill monsterPassiveSkill);
        public Task UpdateMonsterPassiveSkillAsync(MonsterPassiveSkill monsterPassiveSkill);
        public Task DeleteMonsterPassiveSkillAsync(MonsterPassiveSkill monsterPassiveSkill);
    }
}
