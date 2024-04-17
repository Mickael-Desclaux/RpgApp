using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterActionController(IMonsterActionService monsterActionService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<MonsterAction>> GetAll()
        {
            IEnumerable<MonsterAction> monsterActions = await monsterActionService.GetAllMonsterActionAsync();
            return monsterActions;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<MonsterAction>> GetById(int id)
        {
            MonsterAction monsterAction = await monsterActionService.GetMonsterActionByIdAsync(id);
            return Ok(monsterAction);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<MonsterAction>> Add(MonsterAction monsterAction)
        {
            await monsterActionService.AddMonsterActionAsync(monsterAction);
            return Ok(monsterAction);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<MonsterAction>> Update(MonsterAction monsterAction)
        {
            await monsterActionService.UpdateMonsterActionAsync(monsterAction);
            return Ok(monsterAction);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<MonsterAction>> Delete(MonsterAction monsterAction)
        {
            await monsterActionService.DeleteMonsterActionAsync(monsterAction);
            return Ok(monsterAction);
        }
    }
}
