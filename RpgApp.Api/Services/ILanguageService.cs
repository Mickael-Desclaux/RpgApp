using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface ILanguageService
    {
        public Task<IEnumerable<Language>> GetAllLanguageAsync();
        public Task<Language> GetLanguageByIdAsync(int languageId);
    }
}
