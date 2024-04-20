using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResistanceTypeController(IResistanceTypeService resistanceTypeService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<ResistanceType>> GetAll()
        {
            IEnumerable<ResistanceType> resistanceTypes = await resistanceTypeService.GetAllResistanceTypeAsync();
            return resistanceTypes;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<ResistanceType>> GetById(int id)
        {
            ResistanceType resistanceType = await resistanceTypeService.GetResistanceTypeByIdAsync(id);
            return Ok(resistanceType);
        }
    }
}
