using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NonPlayerCharacterController(INonPlayerCharacterService nonPlayerCharacterService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<NonPlayerCharacter>> GetAll()
        {
            IEnumerable<NonPlayerCharacter> nonPlayerCharacters = await nonPlayerCharacterService.GetAllNonPlayerCharacterAsync();
            return nonPlayerCharacters;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<NonPlayerCharacter>> GetById(int id)
        {
            NonPlayerCharacter nonPlayerCharacter = await nonPlayerCharacterService.GetNonPlayerCharacterByIdAsync(id);
            return Ok(nonPlayerCharacter);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<NonPlayerCharacter>> Add(NonPlayerCharacter nonPlayerCharacter)
        {
            await nonPlayerCharacterService.AddNonPlayerCharacterAsync(nonPlayerCharacter);
            return Ok(nonPlayerCharacter);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<NonPlayerCharacter>> Update(NonPlayerCharacter nonPlayerCharacter)
        {
            await nonPlayerCharacterService.UpdateNonPlayerCharacterAsync(nonPlayerCharacter);
            return Ok(nonPlayerCharacter);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<NonPlayerCharacter>> Delete(NonPlayerCharacter nonPlayerCharacter)
        {
            await nonPlayerCharacterService.DeleteNonPlayerCharacterAsync(nonPlayerCharacter);
            return Ok(nonPlayerCharacter);
        }
    }
}
