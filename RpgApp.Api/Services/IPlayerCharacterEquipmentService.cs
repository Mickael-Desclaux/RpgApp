using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IPlayerCharacterEquipmentService
    {
        public Task<IEnumerable<PlayerCharacterEquipment>> GetAllPlayerCharacterEquipmentAsync();
        public Task<PlayerCharacterEquipment> GetPlayerCharacterEquipmentByIdAsync(int playerCharacterEquipmentId);
        public Task AddPlayerCharacterEquipmentAsync(PlayerCharacterEquipment playerCharacterEquipment);
        public Task UpdatePlayerCharacterEquipmentAsync(PlayerCharacterEquipment playerCharacterEquipment);
        public Task DeletePlayerCharacterEquipmentAsync(PlayerCharacterEquipment playerCharacterEquipment);
    }
}
