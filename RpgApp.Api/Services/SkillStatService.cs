using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class SkillStatService(IRepository<SkillStat> skillStatRepository) : ISkillStatService
    {
        public async Task<IEnumerable<SkillStat>> GetAllSkillStatAsync()
        {
            return await skillStatRepository.GetAllAsync();
        }

        public async Task<SkillStat> GetSkillStatByIdAsync(int skillStatId)
        {
            IEnumerable<SkillStat> skillStats = await skillStatRepository.GetAllAsync();
            SkillStat? skillStat = skillStats.FirstOrDefault(s => s.Id == skillStatId);

            if (skillStat == null)
            {
                throw new Exception("Ces statistiques de compétences n'existent pas.");
            }

            return skillStat;
        }

        public async Task AddSkillStatAsync(SkillStat skillStat)
        {
            await skillStatRepository.AddAsync(skillStat);
        }

        public async Task UpdateSkillStatAsync(SkillStat skillStat)
        {
            await skillStatRepository.UpdateAsync(skillStat);
        }

        public async Task DeleteSkillStatAsync(SkillStat skillStat)
        {
            await skillStatRepository.DeleteAsync(skillStat);
        }
    }
}
