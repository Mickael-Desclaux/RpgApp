using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerCharacterEquipmentController(IPlayerCharacterEquipmentService playerCharacterEquipmentService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<PlayerCharacterEquipment>> GetAll()
        {
            IEnumerable<PlayerCharacterEquipment> playerCharacterEquipments = await playerCharacterEquipmentService.GetAllPlayerCharacterEquipmentAsync();
            return playerCharacterEquipments;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<PlayerCharacterEquipment>> GetById(int id)
        {
            PlayerCharacterEquipment playerCharacterEquipment = await playerCharacterEquipmentService.GetPlayerCharacterEquipmentByIdAsync(id);
            return Ok(playerCharacterEquipment);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<PlayerCharacterEquipment>> Add(PlayerCharacterEquipment playerCharacterEquipment)
        {
            await playerCharacterEquipmentService.AddPlayerCharacterEquipmentAsync(playerCharacterEquipment);
            return Ok(playerCharacterEquipment);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<PlayerCharacterEquipment>> Update(PlayerCharacterEquipment playerCharacterEquipment)
        {
            await playerCharacterEquipmentService.UpdatePlayerCharacterEquipmentAsync(playerCharacterEquipment);
            return Ok(playerCharacterEquipment);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<PlayerCharacterEquipment>> Delete(PlayerCharacterEquipment playerCharacterEquipment)
        {
            await playerCharacterEquipmentService.DeletePlayerCharacterEquipmentAsync(playerCharacterEquipment);
            return Ok(playerCharacterEquipment);
        }
    }
}
