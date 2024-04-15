using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerStatController(IPlayerStatService playerStatService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<PlayerStat>> GetAll()
        {
            IEnumerable<PlayerStat> playerStats = await playerStatService.GetAllPlayerStatAsync();
            return playerStats;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<PlayerStat>> GetById(int id)
        {
            PlayerStat playerStat = await playerStatService.GetPlayerStatByIdAsync(id);
            return Ok(playerStat);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<PlayerStat>> Add(PlayerStat playerStat)
        {
            await playerStatService.AddPlayerStatAsync(playerStat);
            return Ok(playerStat);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<PlayerStat>> Update(PlayerStat playerStat)
        {
            await playerStatService.UpdatePlayerStatAsync(playerStat);
            return Ok(playerStat);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<PlayerStat>> Delete(PlayerStat playerStat)
        {
            await playerStatService.DeletePlayerStatAsync(playerStat);
            return Ok(playerStat);
        }
    }
}
