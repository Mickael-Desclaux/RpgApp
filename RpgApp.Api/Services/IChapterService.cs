using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IChapterService
    {
        public Task<IEnumerable<Chapter>> GetAllChapterAsync();
        public Task<Chapter> GetChapterByIdAsync(int chapterId);
        public Task AddChapterAsync(Chapter chapter);
        public Task UpdateChapterAsync(Chapter chapter);
        public Task DeleteChapterAsync(Chapter chapter);
    }
}
