using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatController(IFeatService featService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<Feat>> GetAll()
        {
            IEnumerable<Feat> feats = await featService.GetAllFeatAsync();
            return feats;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<Feat>> GetById(int id)
        {
            Feat feat = await featService.GetFeatByIdAsync(id);
            return Ok(feat);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<Feat>> Add(Feat feat)
        {
            await featService.AddFeatAsync(feat);
            return Ok(feat);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<Feat>> Update(Feat feat)
        {
            await featService.UpdateFeatAsync(feat);
            return Ok(feat);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<Feat>> Delete(Feat feat)
        {
            await featService.DeleteFeatAsync(feat);
            return Ok(feat);
        }
    }
}
