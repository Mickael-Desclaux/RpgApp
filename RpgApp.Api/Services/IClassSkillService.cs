using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IClassSkillService
    {
        public Task<IEnumerable<ClassSkill>> GetAllClassSkillAsync();
        public Task<ClassSkill> GetClassSkillByIdAsync(int classSkillId);
        public Task AddClassSkillAsync(ClassSkill classSkill);
        public Task UpdateClassSkillAsync(ClassSkill classSkill);
        public Task DeleteClassSkillAsync(ClassSkill classSkill);
    }
}
