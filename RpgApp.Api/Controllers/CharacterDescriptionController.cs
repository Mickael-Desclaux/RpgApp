using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterDescriptionController(ICharacterDescriptionService characterDescriptionService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<CharacterDescription>> GetAll()
        {
            IEnumerable<CharacterDescription> characterDescriptions = await characterDescriptionService.GetAllCharacterDescriptionAsync();
            return characterDescriptions;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<CharacterDescription>> GetById(int id)
        {
            CharacterDescription characterDescription = await characterDescriptionService.GetCharacterDescriptionByIdAsync(id);
            return Ok(characterDescription);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<CharacterDescription>> Add(CharacterDescription characterDescription)
        {
            await characterDescriptionService.AddCharacterDescriptionAsync(characterDescription);
            return Ok(characterDescription);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<CharacterDescription>> Update(CharacterDescription characterDescription)
        {
            await characterDescriptionService.UpdateCharacterDescriptionAsync(characterDescription);
            return Ok(characterDescription);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<CharacterDescription>> Delete(CharacterDescription characterDescription)
        {
            await characterDescriptionService.DeleteCharacterDescriptionAsync(characterDescription);
            return Ok(characterDescription);
        }
    }
}
