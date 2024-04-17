using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterPassiveSkillController(IMonsterPassiveSkillService monsterPassiveSkillService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<MonsterPassiveSkill>> GetAll()
        {
            IEnumerable<MonsterPassiveSkill> monsterPassiveSkills = await monsterPassiveSkillService.GetAllMonsterPassiveSkillAsync();
            return monsterPassiveSkills;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<MonsterPassiveSkill>> GetById(int id)
        {
            MonsterPassiveSkill monsterPassiveSkill = await monsterPassiveSkillService.GetMonsterPassiveSkillByIdAsync(id);
            return Ok(monsterPassiveSkill);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<MonsterPassiveSkill>> Add(MonsterPassiveSkill monsterPassiveSkill)
        {
            await monsterPassiveSkillService.AddMonsterPassiveSkillAsync(monsterPassiveSkill);
            return Ok(monsterPassiveSkill);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<MonsterPassiveSkill>> Update(MonsterPassiveSkill monsterPassiveSkill)
        {
            await monsterPassiveSkillService.UpdateMonsterPassiveSkillAsync(monsterPassiveSkill);
            return Ok(monsterPassiveSkill);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<MonsterPassiveSkill>> Delete(MonsterPassiveSkill monsterPassiveSkill)
        {
            await monsterPassiveSkillService.DeleteMonsterPassiveSkillAsync(monsterPassiveSkill);
            return Ok(monsterPassiveSkill);
        }
    }
}
