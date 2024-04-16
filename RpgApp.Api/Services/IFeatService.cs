using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IFeatService
    {
        public Task<IEnumerable<Feat>> GetAllFeatAsync();
        public Task<Feat> GetFeatByIdAsync(int featId);
        public Task AddFeatAsync(Feat feat);
        public Task UpdateFeatAsync(Feat feat);
        public Task DeleteFeatAsync(Feat feat);
    }
}
