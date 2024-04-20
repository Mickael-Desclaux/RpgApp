using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterLanguageController(IMonsterLanguageService monsterLanguageService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<MonsterLanguage>> GetAll()
        {
            IEnumerable<MonsterLanguage> monsterLanguages = await monsterLanguageService.GetAllMonsterLanguageAsync();
            return monsterLanguages;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<MonsterLanguage>> GetById(int id)
        {
            MonsterLanguage monsterLanguage = await monsterLanguageService.GetMonsterLanguageByIdAsync(id);
            return Ok(monsterLanguage);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<MonsterLanguage>> Add(MonsterLanguage monsterLanguage)
        {
            await monsterLanguageService.AddMonsterLanguageAsync(monsterLanguage);
            return Ok(monsterLanguage);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<MonsterLanguage>> Update(MonsterLanguage monsterLanguage)
        {
            await monsterLanguageService.UpdateMonsterLanguageAsync(monsterLanguage);
            return Ok(monsterLanguage);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<MonsterLanguage>> Delete(MonsterLanguage monsterLanguage)
        {
            await monsterLanguageService.DeleteMonsterLanguageAsync(monsterLanguage);
            return Ok(monsterLanguage);
        }
    }
}
