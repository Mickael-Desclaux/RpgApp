using Microsoft.EntityFrameworkCore;
using RpgApp.Api.Entity;

namespace RpgApp.Api.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Spell> Spell { get; init; }
        public DbSet<PlayerCharacter> PlayerCharacter { get; init; }
        public DbSet<DiceType> DiceType { get; init; }
    }
}
