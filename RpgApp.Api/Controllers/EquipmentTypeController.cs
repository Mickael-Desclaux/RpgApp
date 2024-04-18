using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentTypeController(IEquipmentTypeService equipmentTypeService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<EquipmentType>> GetAll()
        {
            IEnumerable<EquipmentType> equipmentTypes = await equipmentTypeService.GetAllEquipmentTypeAsync();
            return equipmentTypes;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<EquipmentType>> GetById(int id)
        {
            EquipmentType equipmentType = await equipmentTypeService.GetEquipmentTypeByIdAsync(id);
            return Ok(equipmentType);
        }
    }
}
