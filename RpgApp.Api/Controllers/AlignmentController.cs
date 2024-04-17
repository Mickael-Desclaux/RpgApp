using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlignmentController(IAlignmentService alignmentService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<Alignment>> GetAll()
        {
            IEnumerable<Alignment> alignments = await alignmentService.GetAllAlignmentAsync();
            return alignments;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<Alignment>> GetById(int id)
        {
            Alignment alignment = await alignmentService.GetAlignmentByIdAsync(id);
            return Ok(alignment);
        }
    }
}
