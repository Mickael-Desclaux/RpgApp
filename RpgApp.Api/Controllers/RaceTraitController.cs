using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceTraitController(IRaceTraitService raceTraitService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<RaceTrait>> GetAll()
        {
            IEnumerable<RaceTrait> raceTraits = await raceTraitService.GetAllRaceTraitAsync();
            return raceTraits;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<RaceTrait>> GetById(int id)
        {
            RaceTrait raceTrait = await raceTraitService.GetRaceTraitByIdAsync(id);
            return Ok(raceTrait);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<RaceTrait>> Add(RaceTrait raceTrait)
        {
            await raceTraitService.AddRaceTraitAsync(raceTrait);
            return Ok(raceTrait);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<RaceTrait>> Update(RaceTrait raceTrait)
        {
            await raceTraitService.UpdateRaceTraitAsync(raceTrait);
            return Ok(raceTrait);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<RaceTrait>> Delete(RaceTrait raceTrait)
        {
            await raceTraitService.DeleteRaceTraitAsync(raceTrait);
            return Ok(raceTrait);
        }
    }
}
