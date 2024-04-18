using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChapterController(IChapterService chapterService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<Chapter>> GetAll()
        {
            IEnumerable<Chapter> chapters = await chapterService.GetAllChapterAsync();
            return chapters;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<Chapter>> GetById(int id)
        {
            Chapter chapter = await chapterService.GetChapterByIdAsync(id);
            return Ok(chapter);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<Chapter>> Add(Chapter chapter)
        {
            await chapterService.AddChapterAsync(chapter);
            return Ok(chapter);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<Chapter>> Update(Chapter chapter)
        {
            await chapterService.UpdateChapterAsync(chapter);
            return Ok(chapter);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<Chapter>> Delete(Chapter chapter)
        {
            await chapterService.DeleteChapterAsync(chapter);
            return Ok(chapter);
        }
    }
}
