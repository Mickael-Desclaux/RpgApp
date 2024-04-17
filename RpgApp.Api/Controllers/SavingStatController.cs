using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavingStatController(ISavingStatService savingStatService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<SavingStat>> GetAll()
        {
            IEnumerable<SavingStat> savingStats = await savingStatService.GetAllSavingStatAsync();
            return savingStats;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<SavingStat>> GetById(int id)
        {
            SavingStat savingStat = await savingStatService.GetSavingStatByIdAsync(id);
            return Ok(savingStat);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<SavingStat>> Add(SavingStat savingStat)
        {
            await savingStatService.AddSavingStatAsync(savingStat);
            return Ok(savingStat);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<SavingStat>> Update(SavingStat savingStat)
        {
            await savingStatService.UpdateSavingStatAsync(savingStat);
            return Ok(savingStat);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<SavingStat>> Delete(SavingStat savingStat)
        {
            await savingStatService.DeleteSavingStatAsync(savingStat);
            return Ok(savingStat);
        }
    }
}
