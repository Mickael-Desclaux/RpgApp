using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class RoleplayService(IRepository<Roleplay> roleplayRepository) : IRoleplayService
    {
        public async Task<IEnumerable<Roleplay>> GetAllRoleplayAsync()
        {
            return await roleplayRepository.GetAllAsync();
        }

        public async Task<Roleplay> GetRoleplayByIdAsync(int roleplayId)
        {
            IEnumerable<Roleplay> roleplays = await roleplayRepository.GetAllAsync();
            Roleplay? roleplay = roleplays.FirstOrDefault(r => r.Id == roleplayId);

            if (roleplay == null)
            {
                throw new Exception("Ce profil n'existe pas.");
            }

            return roleplay;
        }

        public async Task AddRoleplayAsync(Roleplay roleplay)
        {
            await roleplayRepository.AddAsync(roleplay);
        }

        public async Task UpdateRoleplayAsync(Roleplay roleplay)
        {
            await roleplayRepository.UpdateAsync(roleplay);
        }

        public async Task DeleteRoleplayAsync(Roleplay roleplay)
        {
            await roleplayRepository.DeleteAsync(roleplay);
        }
    }
}
