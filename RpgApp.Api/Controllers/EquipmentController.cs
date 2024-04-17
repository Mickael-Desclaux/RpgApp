using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentController(IEquipmentService equipmentService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<Equipment>> GetAll()
        {
            IEnumerable<Equipment> equipments = await equipmentService.GetAllEquipmentAsync();
            return equipments;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<Equipment>> GetById(int id)
        {
            Equipment equipment = await equipmentService.GetEquipmentByIdAsync(id);
            return Ok(equipment);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<Equipment>> Add(Equipment equipment)
        {
            await equipmentService.AddEquipmentAsync(equipment);
            return Ok(equipment);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<Equipment>> Update(Equipment equipment)
        {
            await equipmentService.UpdateEquipmentAsync(equipment);
            return Ok(equipment);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<Equipment>> Delete(Equipment equipment)
        {
            await equipmentService.DeleteEquipmentAsync(equipment);
            return Ok(equipment);
        }
    }
}
