using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleplayController(IRoleplayService roleplayService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<Roleplay>> GetAll()
        {
            IEnumerable<Roleplay> roleplays = await roleplayService.GetAllRoleplayAsync();
            return roleplays;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<Roleplay>> GetById(int id)
        {
            Roleplay roleplay = await roleplayService.GetRoleplayByIdAsync(id);
            return Ok(roleplay);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<Roleplay>> Add(Roleplay roleplay)
        {
            await roleplayService.AddRoleplayAsync(roleplay);
            return Ok(roleplay);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<Roleplay>> Update(Roleplay roleplay)
        {
            await roleplayService.UpdateRoleplayAsync(roleplay);
            return Ok(roleplay);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<Roleplay>> Delete(Roleplay roleplay)
        {
            await roleplayService.DeleteRoleplayAsync(roleplay);
            return Ok(roleplay);
        }
    }
}
