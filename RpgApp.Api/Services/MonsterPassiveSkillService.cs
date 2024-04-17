using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class MonsterPassiveSkillService(IRepository<MonsterPassiveSkill> monsterPassiveSkillRepository) : IMonsterPassiveSkillService
    {
        public async Task<IEnumerable<MonsterPassiveSkill>> GetAllMonsterPassiveSkillAsync()
        {
            return await monsterPassiveSkillRepository.GetAllAsync();
        }

        public async Task<MonsterPassiveSkill> GetMonsterPassiveSkillByIdAsync(int monsterPassiveSkillId)
        {
            IEnumerable<MonsterPassiveSkill> monsterPassiveSkills = await monsterPassiveSkillRepository.GetAllAsync();
            MonsterPassiveSkill? monsterPassiveSkill = monsterPassiveSkills.FirstOrDefault(m => m.Id == monsterPassiveSkillId);

            if (monsterPassiveSkill == null)
            {
                throw new Exception("Cette capacité passive n'existe pas.");
            }

            return monsterPassiveSkill;
        }

        public async Task AddMonsterPassiveSkillAsync(MonsterPassiveSkill monsterPassiveSkill)
        {
            await monsterPassiveSkillRepository.AddAsync(monsterPassiveSkill);
        }

        public async Task UpdateMonsterPassiveSkillAsync(MonsterPassiveSkill monsterPassiveSkill)
        {
            await monsterPassiveSkillRepository.UpdateAsync(monsterPassiveSkill);
        }

        public async Task DeleteMonsterPassiveSkillAsync(MonsterPassiveSkill monsterPassiveSkill)
        {
            await monsterPassiveSkillRepository.DeleteAsync(monsterPassiveSkill);
        }
    }
}
