using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerCharacterLanguageController(IPlayerCharacterLanguageService playerCharacterLanguageService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<PlayerCharacterLanguage>> GetAll()
        {
            IEnumerable<PlayerCharacterLanguage> playerCharacterLanguages = await playerCharacterLanguageService.GetAllPlayerCharacterLanguageAsync();
            return playerCharacterLanguages;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<PlayerCharacterLanguage>> GetById(int id)
        {
            PlayerCharacterLanguage playerCharacterLanguage = await playerCharacterLanguageService.GetPlayerCharacterLanguageByIdAsync(id);
            return Ok(playerCharacterLanguage);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<PlayerCharacterLanguage>> Add(PlayerCharacterLanguage playerCharacterLanguage)
        {
            await playerCharacterLanguageService.AddPlayerCharacterLanguageAsync(playerCharacterLanguage);
            return Ok(playerCharacterLanguage);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<PlayerCharacterLanguage>> Update(PlayerCharacterLanguage playerCharacterLanguage)
        {
            await playerCharacterLanguageService.UpdatePlayerCharacterLanguageAsync(playerCharacterLanguage);
            return Ok(playerCharacterLanguage);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<PlayerCharacterLanguage>> Delete(PlayerCharacterLanguage playerCharacterLanguage)
        {
            await playerCharacterLanguageService.DeletePlayerCharacterLanguageAsync(playerCharacterLanguage);
            return Ok(playerCharacterLanguage);
        }
    }
}
