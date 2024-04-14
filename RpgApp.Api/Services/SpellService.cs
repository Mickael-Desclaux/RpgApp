using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class SpellService(IRepository<Spell> spellRepository) : ISpellService
    {
        public async Task<IEnumerable<Spell>> GetAllSpellAsync()
        {
            return await spellRepository.GetAllAsync();
        }

        public async Task<Spell> GetSpellByIdAsync(int spellId)
        {
            IEnumerable<Spell> spells = await spellRepository.GetAllAsync();
            Spell? spell = spells.FirstOrDefault(s => s.Id == spellId);

            if (spell == null)
            {
                throw new Exception("Le sort n'existe pas.");
            }

            return spell;
        }

        public async Task AddSpellAsync(Spell spell)
        {
            await spellRepository.AddAsync(spell);
        }

        public async Task UpdateSpellAsync(Spell spell)
        {
            await spellRepository.UpdateAsync(spell);
        }

        public async Task DeleteSpellAsync(Spell spell)
        {
            await spellRepository.DeleteAsync(spell);
        }
    }
}
