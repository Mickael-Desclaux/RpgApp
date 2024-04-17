using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class AlignmentService(IRepository<Alignment> alignmentRepository) : IAlignmentService
    {
        public async Task<IEnumerable<Alignment>> GetAllAlignmentAsync()
        {
            return await alignmentRepository.GetAllAsync();
        }

        public async Task<Alignment> GetAlignmentByIdAsync(int alignmentId)
        {
            IEnumerable<Alignment> alignments = await alignmentRepository.GetAllAsync();
            Alignment? alignment = alignments.FirstOrDefault(a => a.Id == alignmentId);

            if (alignment == null)
            {
                throw new Exception("Cet alignement n'existe pas.");
            }

            return alignment;
        }
    }
}
