using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseStatController(IBaseStatService baseStatService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<BaseStat>> GetAll()
        {
            IEnumerable<BaseStat> baseStats = await baseStatService.GetAllBaseStatAsync();
            return baseStats;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<BaseStat>> GetById(int id)
        {
            BaseStat baseStat = await baseStatService.GetBaseStatByIdAsync(id);
            return Ok(baseStat);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<BaseStat>> Add(BaseStat baseStat)
        {
            await baseStatService.AddBaseStatAsync(baseStat);
            return Ok(baseStat);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<BaseStat>> Update(BaseStat baseStat)
        {
            await baseStatService.UpdateBaseStatAsync(baseStat);
            return Ok(baseStat);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<BaseStat>> Delete(BaseStat baseStat)
        {
            await baseStatService.DeleteBaseStatAsync(baseStat);
            return Ok(baseStat);
        }
    }
}
