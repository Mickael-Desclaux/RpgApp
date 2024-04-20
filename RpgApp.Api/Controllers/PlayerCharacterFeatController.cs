using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerCharacterFeatController(IPlayerCharacterFeatService playerCharacterFeatService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<PlayerCharacterFeat>> GetAll()
        {
            IEnumerable<PlayerCharacterFeat> playerCharacterFeats = await playerCharacterFeatService.GetAllPlayerCharacterFeatAsync();
            return playerCharacterFeats;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<PlayerCharacterFeat>> GetById(int id)
        {
            PlayerCharacterFeat playerCharacterFeat = await playerCharacterFeatService.GetPlayerCharacterFeatByIdAsync(id);
            return Ok(playerCharacterFeat);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<PlayerCharacterFeat>> Add(PlayerCharacterFeat playerCharacterFeat)
        {
            await playerCharacterFeatService.AddPlayerCharacterFeatAsync(playerCharacterFeat);
            return Ok(playerCharacterFeat);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<PlayerCharacterFeat>> Update(PlayerCharacterFeat playerCharacterFeat)
        {
            await playerCharacterFeatService.UpdatePlayerCharacterFeatAsync(playerCharacterFeat);
            return Ok(playerCharacterFeat);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<PlayerCharacterFeat>> Delete(PlayerCharacterFeat playerCharacterFeat)
        {
            await playerCharacterFeatService.DeletePlayerCharacterFeatAsync(playerCharacterFeat);
            return Ok(playerCharacterFeat);
        }
    }
}
