using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapController(IMapService mapService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<Map>> GetAll()
        {
            IEnumerable<Map> maps = await mapService.GetAllMapAsync();
            return maps;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<Map>> GetById(int id)
        {
            Map map = await mapService.GetMapByIdAsync(id);
            return Ok(map);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<Map>> Add(Map map)
        {
            await mapService.AddMapAsync(map);
            return Ok(map);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<Map>> Update(Map map)
        {
            await mapService.UpdateMapAsync(map);
            return Ok(map);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<Map>> Delete(Map map)
        {
            await mapService.DeleteMapAsync(map);
            return Ok(map);
        }
    }
}
