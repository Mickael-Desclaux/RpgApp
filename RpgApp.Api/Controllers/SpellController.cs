using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpellController(ISpellService spellService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<Spell>> GetAll()
        {
            IEnumerable<Spell> spells = await spellService.GetAllSpellAsync();
            return spells;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<Spell>> GetById(int id)
        {
            Spell spell = await spellService.GetSpellByIdAsync(id);
            return Ok(spell);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<Spell>> Add(Spell spell)
        {
            await spellService.AddSpellAsync(spell);
            return Ok(spell);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<Spell>> Update(Spell spell)
        {
            await spellService.UpdateSpellAsync(spell);
            return Ok(spell);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<Spell>> Delete(Spell spell)
        {
            await spellService.DeleteSpellAsync(spell);
            return Ok(spell);
        }
    }
}
