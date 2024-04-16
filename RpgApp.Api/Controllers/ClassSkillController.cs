using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassSkillController(IClassSkillService classSkillService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<ClassSkill>> GetAll()
        {
            IEnumerable<ClassSkill> classSkills = await classSkillService.GetAllClassSkillAsync();
            return classSkills;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<ClassSkill>> GetById(int id)
        {
            ClassSkill classSkill = await classSkillService.GetClassSkillByIdAsync(id);
            return Ok(classSkill);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<ClassSkill>> Add(ClassSkill classSkill)
        {
            await classSkillService.AddClassSkillAsync(classSkill);
            return Ok(classSkill);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<ClassSkill>> Update(ClassSkill classSkill)
        {
            await classSkillService.UpdateClassSkillAsync(classSkill);
            return Ok(classSkill);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<ClassSkill>> Delete(ClassSkill classSkill)
        {
            await classSkillService.DeleteClassSkillAsync(classSkill);
            return Ok(classSkill);
        }
    }
}
