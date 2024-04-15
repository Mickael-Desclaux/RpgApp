using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerCharacterController(IPlayerCharacterService playerCharacterService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<PlayerCharacter>> GetAll()
        {
            IEnumerable<PlayerCharacter> playerCharacters = await playerCharacterService.GetAllPlayerCharacterAsync();
            return playerCharacters;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<PlayerCharacter>> GetById(int id)
        {
            PlayerCharacter playerCharacter = await playerCharacterService.GetPlayerCharacterByIdAsync(id);
            return Ok(playerCharacter);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<PlayerCharacter>> Add(PlayerCharacter playerCharacter)
        {
            await playerCharacterService.AddPlayerCharacterAsync(playerCharacter);
            return Ok(playerCharacter);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<PlayerCharacter>> Update(PlayerCharacter playerCharacter)
        {
            await playerCharacterService.UpdatePlayerCharacterAsync(playerCharacter);
            return Ok(playerCharacter);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<PlayerCharacter>> Delete(PlayerCharacter playerCharacter)
        {
            await playerCharacterService.DeletePlayerCharacterAsync(playerCharacter);
            return Ok(playerCharacter);
        }
    }
}
