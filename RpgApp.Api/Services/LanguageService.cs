using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class LanguageService(IRepository<Language> languageRepository) : ILanguageService
    {
        public async Task<IEnumerable<Language>> GetAllLanguageAsync()
        {
            return await languageRepository.GetAllAsync();
        }

        public async Task<Language> GetLanguageByIdAsync(int languageId)
        {
            IEnumerable<Language> languages = await languageRepository.GetAllAsync();
            Language? language = languages.FirstOrDefault(l => l.Id == languageId);

            if (language == null)
            {
                throw new Exception("Cette langue n'existe pas.");
            }

            return language;
        }
    }
}
