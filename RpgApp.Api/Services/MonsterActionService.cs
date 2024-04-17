using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class MonsterActionService(IRepository<MonsterAction> monsterActionRepository) : IMonsterActionService
    {
        public async Task<IEnumerable<MonsterAction>> GetAllMonsterActionAsync()
        {
            return await monsterActionRepository.GetAllAsync();
        }

        public async Task<MonsterAction> GetMonsterActionByIdAsync(int monsterActionId)
        {
            IEnumerable<MonsterAction> monsterActions = await monsterActionRepository.GetAllAsync();
            MonsterAction? monsterAction = monsterActions.FirstOrDefault(m => m.Id == monsterActionId);

            if (monsterAction == null)
            {
                throw new Exception("Cette compétence n'existe pas.");
            }

            return monsterAction;
        }

        public async Task AddMonsterActionAsync(MonsterAction monsterAction)
        {
            await monsterActionRepository.AddAsync(monsterAction);
        }

        public async Task UpdateMonsterActionAsync(MonsterAction monsterAction)
        {
            await monsterActionRepository.UpdateAsync(monsterAction);
        }

        public async Task DeleteMonsterActionAsync(MonsterAction monsterAction)
        {
            await monsterActionRepository.DeleteAsync(monsterAction);
        }
    }
}
