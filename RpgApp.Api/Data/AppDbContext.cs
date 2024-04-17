using Microsoft.EntityFrameworkCore;
using RpgApp.Api.Entity;

namespace RpgApp.Api.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Spell> Spell { get; init; }
        public DbSet<PlayerCharacter> PlayerCharacter { get; init; }
        public DbSet<DiceType> DiceType { get; init; }
        public DbSet<PlayerStat> PlayerStat { get; init; }
        public DbSet<NonPlayerCharacter> NonPlayerCharacter { get; init; }
        public DbSet<Monster> Monster { get; init; }
        public DbSet<Image> Image { get; init; }
        public DbSet<CharacterClass> CharacterClass { get; init; }
        public DbSet<ClassSkill> ClassSkill { get; init; }
        public DbSet<Race> Race { get; init; }
        public DbSet<RaceTrait> RaceTrait { get; init; }
        public DbSet<Feat> Feat { get; init; }
        public DbSet<Language> Language { get; init; }
        public DbSet<Background> Background { get; init; }
        public DbSet<Alignment> Alignment { get; init; }
        public DbSet<BaseStat> BaseStat { get; init; }
        public DbSet<SavingStat> SavingStat { get; init; }
        public DbSet<SkillStat> SkillStat { get; init; }
        public DbSet<Resistance> Resistance { get; init; }
        public DbSet<Immunity> Immunity { get; init; }
        public DbSet<MonsterPassiveSkill> MonsterPassiveSkill { get; init; }
        public DbSet<MonsterAction> MonsterAction { get; init; }
        public DbSet<Roleplay> Roleplay { get; init; }
    }
}
