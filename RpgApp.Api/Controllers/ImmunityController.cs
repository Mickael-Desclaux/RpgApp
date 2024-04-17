using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImmunityController(IImmunityService immunityService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<Immunity>> GetAll()
        {
            IEnumerable<Immunity> immunities = await immunityService.GetAllImmunityAsync();
            return immunities;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<Immunity>> GetById(int id)
        {
            Immunity immunity = await immunityService.GetImmunityByIdAsync(id);
            return Ok(immunity);
        }
    }
}
