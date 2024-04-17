using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class ResistanceService(IRepository<Resistance> resistanceRepository) : IResistanceService
    {
        public async Task<IEnumerable<Resistance>> GetAllResistanceAsync()
        {
            return await resistanceRepository.GetAllAsync();
        }

        public async Task<Resistance> GetResistanceByIdAsync(int resistanceId)
        {
            IEnumerable<Resistance> resistances = await resistanceRepository.GetAllAsync();
            Resistance? resistance = resistances.FirstOrDefault(r => r.Id == resistanceId);

            if (resistance == null)
            {
                throw new Exception("La résistance n'existe pas.");
            }

            return resistance;
        }
    }
}
