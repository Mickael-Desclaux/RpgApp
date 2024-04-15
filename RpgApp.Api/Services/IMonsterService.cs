using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IMonsterService
    {
        public Task<IEnumerable<Monster>> GetAllMonsterAsync();
        public Task<Monster> GetMonsterByIdAsync(int monsterId);
        public Task AddMonsterAsync(Monster monster);
        public Task UpdateMonsterAsync(Monster monster);
        public Task DeleteMonsterAsync(Monster monster);
    }
}
