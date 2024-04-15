using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterController(IMonsterService monsterService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<Monster>> GetAll()
        {
            IEnumerable<Monster> monsters = await monsterService.GetAllMonsterAsync();
            return monsters;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<Monster>> GetById(int id)
        {
            Monster monster = await monsterService.GetMonsterByIdAsync(id);
            return Ok(monster);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<Monster>> Add(Monster monster)
        {
            await monsterService.AddMonsterAsync(monster);
            return Ok(monster);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<Monster>> Update(Monster monster)
        {
            await monsterService.UpdateMonsterAsync(monster);
            return Ok(monster);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<Monster>> Delete(Monster monster)
        {
            await monsterService.DeleteMonsterAsync(monster);
            return Ok(monster);
        }
    }
}
