using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterClassController(ICharacterClassService characterClassService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<CharacterClass>> GetAll()
        {
            IEnumerable<CharacterClass> characterClasss = await characterClassService.GetAllCharacterClassAsync();
            return characterClasss;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<CharacterClass>> GetById(int id)
        {
            CharacterClass characterClass = await characterClassService.GetCharacterClassByIdAsync(id);
            return Ok(characterClass);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<CharacterClass>> Add(CharacterClass characterClass)
        {
            await characterClassService.AddCharacterClassAsync(characterClass);
            return Ok(characterClass);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<CharacterClass>> Update(CharacterClass characterClass)
        {
            await characterClassService.UpdateCharacterClassAsync(characterClass);
            return Ok(characterClass);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<CharacterClass>> Delete(CharacterClass characterClass)
        {
            await characterClassService.DeleteCharacterClassAsync(characterClass);
            return Ok(characterClass);
        }
    }
}
