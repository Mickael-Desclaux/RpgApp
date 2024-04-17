using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResistanceController(IResistanceService resistanceService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<Resistance>> GetAll()
        {
            IEnumerable<Resistance> resistances = await resistanceService.GetAllResistanceAsync();
            return resistances;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<Resistance>> GetById(int id)
        {
            Resistance resistance = await resistanceService.GetResistanceByIdAsync(id);
            return Ok(resistance);
        }
    }
}
