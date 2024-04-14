namespace RpgApp.Api.Repository
{
    public interface IRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync();
        public Task<T> AddAsync();
        public Task<T> UpdateAsync();
        public Task<T> DeleteAsync();
    }
}
