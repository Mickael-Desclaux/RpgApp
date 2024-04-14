using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface ISpellService
    {
        public Task<IEnumerable<Spell>> GetAllSpellAsync();
        public Task<Spell> GetSpellByIdAsync (int spellId);
        public Task AddSpellAsync(Spell spell);
        public Task UpdateSpellAsync(Spell spell);
        public Task DeleteSpellAsync(Spell spell);
    }
}
