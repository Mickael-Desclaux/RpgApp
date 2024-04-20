using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterResistanceController(ICharacterResistanceService characterResistanceService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<CharacterResistance>> GetAll()
        {
            IEnumerable<CharacterResistance> characterResistances = await characterResistanceService.GetAllCharacterResistanceAsync();
            return characterResistances;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<CharacterResistance>> GetById(int id)
        {
            CharacterResistance characterResistance = await characterResistanceService.GetCharacterResistanceByIdAsync(id);
            return Ok(characterResistance);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<CharacterResistance>> Add(CharacterResistance characterResistance)
        {
            await characterResistanceService.AddCharacterResistanceAsync(characterResistance);
            return Ok(characterResistance);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<CharacterResistance>> Update(CharacterResistance characterResistance)
        {
            await characterResistanceService.UpdateCharacterResistanceAsync(characterResistance);
            return Ok(characterResistance);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<CharacterResistance>> Delete(CharacterResistance characterResistance)
        {
            await characterResistanceService.DeleteCharacterResistanceAsync(characterResistance);
            return Ok(characterResistance);
        }
    }
}
