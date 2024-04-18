using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class ChapterService(IRepository<Chapter> chapterRepository) : IChapterService
    {
        public async Task<IEnumerable<Chapter>> GetAllChapterAsync()
        {
            return await chapterRepository.GetAllAsync();
        }

        public async Task<Chapter> GetChapterByIdAsync(int chapterId)
        {
            IEnumerable<Chapter> chapters = await chapterRepository.GetAllAsync();
            Chapter? chapter = chapters.FirstOrDefault(c => c.Id == chapterId);

            if (chapter == null)
            {
                throw new Exception("Ce chapitre n'existe pas.");
            }

            return chapter;
        }

        public async Task AddChapterAsync(Chapter chapter)
        {
            await chapterRepository.AddAsync(chapter);
        }

        public async Task UpdateChapterAsync(Chapter chapter)
        {
            await chapterRepository.UpdateAsync(chapter);
        }

        public async Task DeleteChapterAsync(Chapter chapter)
        {
            await chapterRepository.DeleteAsync(chapter);
        }
    }
}
