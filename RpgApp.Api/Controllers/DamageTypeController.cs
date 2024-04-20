using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DamageTypeController(IDamageTypeService damageTypeService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<DamageType>> GetAll()
        {
            IEnumerable<DamageType> damageTypes = await damageTypeService.GetAllDamageTypeAsync();
            return damageTypes;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<DamageType>> GetById(int id)
        {
            DamageType damageType = await damageTypeService.GetDamageTypeByIdAsync(id);
            return Ok(damageType);
        }
    }
}
