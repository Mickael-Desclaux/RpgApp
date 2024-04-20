using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerCharacterSpellController(IPlayerCharacterSpellService playerCharacterSpellService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<PlayerCharacterSpell>> GetAll()
        {
            IEnumerable<PlayerCharacterSpell> playerCharacterSpells = await playerCharacterSpellService.GetAllPlayerCharacterSpellAsync();
            return playerCharacterSpells;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<PlayerCharacterSpell>> GetById(int id)
        {
            PlayerCharacterSpell playerCharacterSpell = await playerCharacterSpellService.GetPlayerCharacterSpellByIdAsync(id);
            return Ok(playerCharacterSpell);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<PlayerCharacterSpell>> Add(PlayerCharacterSpell playerCharacterSpell)
        {
            await playerCharacterSpellService.AddPlayerCharacterSpellAsync(playerCharacterSpell);
            return Ok(playerCharacterSpell);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<PlayerCharacterSpell>> Update(PlayerCharacterSpell playerCharacterSpell)
        {
            await playerCharacterSpellService.UpdatePlayerCharacterSpellAsync(playerCharacterSpell);
            return Ok(playerCharacterSpell);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<PlayerCharacterSpell>> Delete(PlayerCharacterSpell playerCharacterSpell)
        {
            await playerCharacterSpellService.DeletePlayerCharacterSpellAsync(playerCharacterSpell);
            return Ok(playerCharacterSpell);
        }
    }
}
