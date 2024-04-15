using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class MonsterService(IRepository<Monster> monsterRepository) : IMonsterService
    {
        public async Task<IEnumerable<Monster>> GetAllMonsterAsync()
        {
            return await monsterRepository.GetAllAsync();
        }

        public async Task<Monster> GetMonsterByIdAsync(int monsterId)
        {
            IEnumerable<Monster> monsters = await monsterRepository.GetAllAsync();
            Monster? monster = monsters.FirstOrDefault(m => m.Id == monsterId);

            if (monster == null)
            {
                throw new Exception("Le monstre n'existe pas");
            }

            return monster;
        }

        public async Task AddMonsterAsync(Monster monster)
        {
            await monsterRepository.AddAsync(monster);
        }

        public async Task UpdateMonsterAsync(Monster monster)
        {
            await monsterRepository.UpdateAsync(monster);
        }

        public async Task DeleteMonsterAsync(Monster monster)
        {
            await monsterRepository.DeleteAsync(monster);
        }
    }
}
