using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController(ILanguageService languageService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<Language>> GetAll()
        {
            IEnumerable<Language> languages = await languageService.GetAllLanguageAsync();
            return languages;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<Language>> GetById(int id)
        {
            Language language = await languageService.GetLanguageByIdAsync(id);
            return Ok(language);
        }
    }
}
