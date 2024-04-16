using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class ClassSkillService(IRepository<ClassSkill> classSkillRepository) : IClassSkillService
    {
        public async Task<IEnumerable<ClassSkill>> GetAllClassSkillAsync()
        {
            return await classSkillRepository.GetAllAsync();
        }

        public async Task<ClassSkill> GetClassSkillByIdAsync(int classSkillId)
        {
            IEnumerable<ClassSkill> classSkills = await classSkillRepository.GetAllAsync();
            ClassSkill? classSkill = classSkills.FirstOrDefault(c => c.Id == classSkillId);

            if (classSkill == null)
            {
                throw new Exception("Cette capacité de classe n'existe pas.");
            }

            return classSkill;
        }

        public async Task AddClassSkillAsync(ClassSkill classSkill)
        {
            await classSkillRepository.AddAsync(classSkill);
        }

        public async Task UpdateClassSkillAsync(ClassSkill classSkill)
        {
            await classSkillRepository.UpdateAsync(classSkill);
        }

        public async Task DeleteClassSkillAsync(ClassSkill classSkill)
        {
            await classSkillRepository.DeleteAsync(classSkill);
        }
    }
}
