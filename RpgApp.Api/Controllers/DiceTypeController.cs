using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiceTypeController(IDiceTypeService diceTypeService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<DiceType>> GetAll()
        {
            IEnumerable<DiceType> diceTypes = await diceTypeService.GetAllDiceTypeAsync();
            return diceTypes;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<DiceType>> GetById(int id)
        {
            DiceType diceType = await diceTypeService.GetDiceTypeByIdAsync(id);
            return Ok(diceType);
        }
    }
}
