using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IPlayerStatService
    {
        public Task<IEnumerable<PlayerStat>> GetAllPlayerStatAsync();
        public Task<PlayerStat> GetPlayerStatByIdAsync(int playerStatId);
        public Task AddPlayerStatAsync(PlayerStat playerStat);
        public Task UpdatePlayerStatAsync(PlayerStat playerStat);
        public Task DeletePlayerStatAsync(PlayerStat playerStat);
    }
}
