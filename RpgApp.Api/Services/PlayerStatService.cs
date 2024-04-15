using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class PlayerStatService(IRepository<PlayerStat> playerStatRepository) : IPlayerStatService
    {
        public async Task<IEnumerable<PlayerStat>> GetAllPlayerStatAsync()
        {
            return await playerStatRepository.GetAllAsync();
        }

        public async Task<PlayerStat> GetPlayerStatByIdAsync(int playerStatId)
        {
            IEnumerable<PlayerStat> playerStats = await playerStatRepository.GetAllAsync();
            PlayerStat? playerStat = playerStats.FirstOrDefault(p => p.Id == playerStatId);

            if (playerStat == null)
            {
                throw new Exception("L'id de ces statistiques n'existe pas.");
            }

            return playerStat;
        }

        public async Task AddPlayerStatAsync(PlayerStat playerStat)
        {
            await playerStatRepository.AddAsync(playerStat);
        }

        public async Task UpdatePlayerStatAsync(PlayerStat playerStat)
        {
            await playerStatRepository.UpdateAsync(playerStat);
        }

        public async Task DeletePlayerStatAsync(PlayerStat playerStat)
        {
            await playerStatRepository.DeleteAsync(playerStat);
        }
    }
}
