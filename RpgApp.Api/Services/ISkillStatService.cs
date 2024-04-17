using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface ISkillStatService
    {
        public Task<IEnumerable<SkillStat>> GetAllSkillStatAsync();
        public Task<SkillStat> GetSkillStatByIdAsync(int skillStatId);
        public Task AddSkillStatAsync(SkillStat skillStat);
        public Task UpdateSkillStatAsync(SkillStat skillStat);
        public Task DeleteSkillStatAsync(SkillStat skillStat);
    }
}
