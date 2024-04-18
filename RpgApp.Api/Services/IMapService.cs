using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IMapService
    {
        public Task<IEnumerable<Map>> GetAllMapAsync();
        public Task<Map> GetMapByIdAsync(int mapId);
        public Task AddMapAsync(Map map);
        public Task UpdateMapAsync(Map map);
        public Task DeleteMapAsync(Map map);
    }
}
