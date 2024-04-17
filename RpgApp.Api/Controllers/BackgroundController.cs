using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BackgroundController(IBackgroundService backgroundService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<Background>> GetAll()
        {
            IEnumerable<Background> backgrounds = await backgroundService.GetAllBackgroundAsync();
            return backgrounds;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<Background>> GetById(int id)
        {
            Background background = await backgroundService.GetBackgroundByIdAsync(id);
            return Ok(background);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<Background>> Add(Background background)
        {
            await backgroundService.AddBackgroundAsync(background);
            return Ok(background);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<Background>> Update(Background background)
        {
            await backgroundService.UpdateBackgroundAsync(background);
            return Ok(background);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<Background>> Delete(Background background)
        {
            await backgroundService.DeleteBackgroundAsync(background);
            return Ok(background);
        }
    }
}
