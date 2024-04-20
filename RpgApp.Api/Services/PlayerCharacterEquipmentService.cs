using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class PlayerCharacterEquipmentService(IRepository<PlayerCharacterEquipment> playerCharacterEquipmentRepository) : IPlayerCharacterEquipmentService
    {
        public async Task<IEnumerable<PlayerCharacterEquipment>> GetAllPlayerCharacterEquipmentAsync()
        {
            return await playerCharacterEquipmentRepository.GetAllAsync();
        }

        public async Task<PlayerCharacterEquipment> GetPlayerCharacterEquipmentByIdAsync(int playerCharacterEquipmentId)
        {
            IEnumerable<PlayerCharacterEquipment> playerCharacterEquipments = await playerCharacterEquipmentRepository.GetAllAsync();
            PlayerCharacterEquipment? playerCharacterEquipment = playerCharacterEquipments.FirstOrDefault(p => p.Id == playerCharacterEquipmentId);

            if (playerCharacterEquipment == null)
            {
                throw new Exception("Cette association joueur / équipement n'existe pas.");
            }

            return playerCharacterEquipment;
        }

        public async Task AddPlayerCharacterEquipmentAsync(PlayerCharacterEquipment playerCharacterEquipment)
        {
            await playerCharacterEquipmentRepository.AddAsync(playerCharacterEquipment);
        }

        public async Task UpdatePlayerCharacterEquipmentAsync(PlayerCharacterEquipment playerCharacterEquipment)
        {
            await playerCharacterEquipmentRepository.UpdateAsync(playerCharacterEquipment);
        }

        public async Task DeletePlayerCharacterEquipmentAsync(PlayerCharacterEquipment playerCharacterEquipment)
        {
            await playerCharacterEquipmentRepository.DeleteAsync(playerCharacterEquipment);
        }
    }
}
