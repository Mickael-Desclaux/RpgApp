using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IRoleplayService
    {
        public Task<IEnumerable<Roleplay>> GetAllRoleplayAsync();
        public Task<Roleplay> GetRoleplayByIdAsync(int roleplayId);
        public Task AddRoleplayAsync(Roleplay roleplay);
        public Task UpdateRoleplayAsync(Roleplay roleplay);
        public Task DeleteRoleplayAsync(Roleplay roleplay);
    }
}
