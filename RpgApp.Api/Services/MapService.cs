using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class MapService(IRepository<Map> mapRepository) : IMapService
    {
        public async Task<IEnumerable<Map>> GetAllMapAsync()
        {
            return await mapRepository.GetAllAsync();
        }

        public async Task<Map> GetMapByIdAsync(int mapId)
        {
            IEnumerable<Map> maps = await mapRepository.GetAllAsync();
            Map? map = maps.FirstOrDefault(m => m.Id == mapId);

            if (map == null)
            {
                throw new Exception("Cette carte n'existe pas.");
            }

            return map;
        }

        public async Task AddMapAsync(Map map)
        {
            await mapRepository.AddAsync(map);
        }

        public async Task UpdateMapAsync(Map map)
        {
            await mapRepository.UpdateAsync(map);
        }

        public async Task DeleteMapAsync(Map map)
        {
            await mapRepository.DeleteAsync(map);
        }
    }
}
