using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IAlignmentService
    {
        public Task<IEnumerable<Alignment>> GetAllAlignmentAsync();
        public Task<Alignment> GetAlignmentByIdAsync(int alignmentId);
    }
}
