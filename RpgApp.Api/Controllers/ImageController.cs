using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController(IImageService imageService) : ControllerBase
    {
        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<Image>> GetById(int id)
        {
            Image image = await imageService.GetImageByIdAsync(id);
            return Ok(image);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<Image>> Add(Image image)
        {
            await imageService.AddImageAsync(image);
            return Ok(image);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<Image>> Update(Image image)
        {
            await imageService.UpdateImageAsync(image);
            return Ok(image);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<Image>> Image(Image image)
        {
            await imageService.DeleteImageAsync(image);
            return Ok(image);
        }
    }
}
