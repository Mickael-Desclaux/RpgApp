using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IMonsterActionService
    {
        public Task<IEnumerable<MonsterAction>> GetAllMonsterActionAsync();
        public Task<MonsterAction> GetMonsterActionByIdAsync(int monsterActionId);
        public Task AddMonsterActionAsync(MonsterAction monsterAction);
        public Task UpdateMonsterActionAsync(MonsterAction monsterAction);
        public Task DeleteMonsterActionAsync(MonsterAction monsterAction);
    }
}
