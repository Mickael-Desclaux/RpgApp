using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillStatController(ISkillStatService skillStatService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<SkillStat>> GetAll()
        {
            IEnumerable<SkillStat> skillStats = await skillStatService.GetAllSkillStatAsync();
            return skillStats;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<SkillStat>> GetById(int id)
        {
            SkillStat skillStat = await skillStatService.GetSkillStatByIdAsync(id);
            return Ok(skillStat);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<SkillStat>> Add(SkillStat skillStat)
        {
            await skillStatService.AddSkillStatAsync(skillStat);
            return Ok(skillStat);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<SkillStat>> Update(SkillStat skillStat)
        {
            await skillStatService.UpdateSkillStatAsync(skillStat);
            return Ok(skillStat);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<SkillStat>> Delete(SkillStat skillStat)
        {
            await skillStatService.DeleteSkillStatAsync(skillStat);
            return Ok(skillStat);
        }
    }
}
