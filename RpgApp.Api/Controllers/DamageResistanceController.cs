using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DamageResistanceController(IDamageResistanceService damageResistanceService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<DamageResistance>> GetAll()
        {
            IEnumerable<DamageResistance> damageResistances = await damageResistanceService.GetAllDamageResistanceAsync();
            return damageResistances;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<DamageResistance>> GetById(int id)
        {
            DamageResistance damageResistance = await damageResistanceService.GetDamageResistanceByIdAsync(id);
            return Ok(damageResistance);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<DamageResistance>> Add(DamageResistance damageResistance)
        {
            await damageResistanceService.AddDamageResistanceAsync(damageResistance);
            return Ok(damageResistance);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<DamageResistance>> Update(DamageResistance damageResistance)
        {
            await damageResistanceService.UpdateDamageResistanceAsync(damageResistance);
            return Ok(damageResistance);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<DamageResistance>> Delete(DamageResistance damageResistance)
        {
            await damageResistanceService.DeleteDamageResistanceAsync(damageResistance);
            return Ok(damageResistance);
        }
    }
}
