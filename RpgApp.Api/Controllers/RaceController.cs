using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceController(IRaceService raceService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<Race>> GetAll()
        {
            IEnumerable<Race> races = await raceService.GetAllRaceAsync();
            return races;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<Race>> GetById(int id)
        {
            Race race = await raceService.GetRaceByIdAsync(id);
            return Ok(race);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<Race>> Add(Race race)
        {
            await raceService.AddRaceAsync(race);
            return Ok(race);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<Race>> Update(Race race)
        {
            await raceService.UpdateRaceAsync(race);
            return Ok(race);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<Race>> Delete(Race race)
        {
            await raceService.DeleteRaceAsync(race);
            return Ok(race);
        }
    }
}
