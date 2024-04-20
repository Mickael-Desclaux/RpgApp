using RpgApp.Api.Data;
using Microsoft.EntityFrameworkCore;
using RpgApp.Api.Entity;
using RpgApp.Api.Repository;
using RpgApp.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GlobalDb")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Repositories

builder.Services.AddScoped<IRepository<Spell>, Repository<Spell>>();
builder.Services.AddScoped<IRepository<PlayerCharacter>, Repository<PlayerCharacter>>();
builder.Services.AddScoped<IRepository<DiceType>, Repository<DiceType>>();
builder.Services.AddScoped<IRepository<PlayerStat>, Repository<PlayerStat>>();
builder.Services.AddScoped<IRepository<NonPlayerCharacter>, Repository<NonPlayerCharacter>>();
builder.Services.AddScoped<IRepository<Monster>, Repository<Monster>>();
builder.Services.AddScoped<IRepository<Image>, Repository<Image>>();
builder.Services.AddScoped<IRepository<CharacterClass>, Repository<CharacterClass>>();
builder.Services.AddScoped<IRepository<ClassSkill>, Repository<ClassSkill>>();
builder.Services.AddScoped<IRepository<Race>, Repository<Race>>();
builder.Services.AddScoped<IRepository<RaceTrait>, Repository<RaceTrait>>();
builder.Services.AddScoped<IRepository<Feat>, Repository<Feat>>();
builder.Services.AddScoped<IRepository<Language>, Repository<Language>>();
builder.Services.AddScoped<IRepository<Background>, Repository<Background>>();
builder.Services.AddScoped<IRepository<Alignment>, Repository<Alignment>>();
builder.Services.AddScoped<IRepository<BaseStat>, Repository<BaseStat>>();
builder.Services.AddScoped<IRepository<SavingStat>, Repository<SavingStat>>();
builder.Services.AddScoped<IRepository<SkillStat>, Repository<SkillStat>>();
builder.Services.AddScoped<IRepository<MonsterPassiveSkill>, Repository<MonsterPassiveSkill>>();
builder.Services.AddScoped<IRepository<MonsterAction>, Repository<MonsterAction>>();
builder.Services.AddScoped<IRepository<Roleplay>, Repository<Roleplay>>();
builder.Services.AddScoped<IRepository<Equipment>, Repository<Equipment>>();
builder.Services.AddScoped<IRepository<EquipmentType>, Repository<EquipmentType>>();
builder.Services.AddScoped<IRepository<CharacterDescription>, Repository<CharacterDescription>>();
builder.Services.AddScoped<IRepository<GameMasterNote>, Repository<GameMasterNote>>();
builder.Services.AddScoped<IRepository<Chapter>, Repository<Chapter>>();
builder.Services.AddScoped<IRepository<Map>, Repository<Map>>();
builder.Services.AddScoped<IRepository<DamageType>, Repository<DamageType>>();
builder.Services.AddScoped<IRepository<ResistanceType>, Repository<ResistanceType>>();
builder.Services.AddScoped<IRepository<DamageResistance>, Repository<DamageResistance>>();
builder.Services.AddScoped<IRepository<PlayerCharacterSpell>, Repository<PlayerCharacterSpell>>();
builder.Services.AddScoped<IRepository<PlayerCharacterFeat>, Repository<PlayerCharacterFeat>>();
builder.Services.AddScoped<IRepository<PlayerCharacterLanguage>, Repository<PlayerCharacterLanguage>>();
builder.Services.AddScoped<IRepository<PlayerCharacterEquipment>, Repository<PlayerCharacterEquipment>>();
builder.Services.AddScoped<IRepository<MonsterLanguage>, Repository<MonsterLanguage>>();

#endregion

#region Services

builder.Services.AddTransient<ISpellService, SpellService>();
builder.Services.AddTransient<IPlayerCharacterService, PlayerCharacterService>();
builder.Services.AddTransient<IDiceTypeService, DiceTypeService>();
builder.Services.AddTransient<IPlayerStatService, PlayerStatService>();
builder.Services.AddTransient<INonPlayerCharacterService, NonPlayerCharacterService>();
builder.Services.AddTransient<IMonsterService, MonsterService>();
builder.Services.AddTransient<IImageService, ImageService>();
builder.Services.AddTransient<ICharacterClassService, CharacterClassService>();
builder.Services.AddTransient<IClassSkillService, ClassSkillService>();
builder.Services.AddTransient<IRaceService, RaceService>();
builder.Services.AddTransient<IRaceTraitService, RaceTraitService>();
builder.Services.AddTransient<IFeatService, FeatService>();
builder.Services.AddTransient<ILanguageService, LanguageService>();
builder.Services.AddTransient<IBackgroundService, RpgApp.Api.Services.BackgroundService>();
builder.Services.AddTransient<IAlignmentService, AlignmentService>();
builder.Services.AddTransient<IBaseStatService, BaseStatService>();
builder.Services.AddTransient<ISavingStatService, SavingStatService>();
builder.Services.AddTransient<ISkillStatService, SkillStatService>();
builder.Services.AddTransient<IMonsterPassiveSkillService, MonsterPassiveSkillService>();
builder.Services.AddTransient<IMonsterActionService, MonsterActionService>();
builder.Services.AddTransient<IRoleplayService, RoleplayService>();
builder.Services.AddTransient<IEquipmentService, EquipmentService>();
builder.Services.AddTransient<IEquipmentTypeService, EquipmentTypeService>();
builder.Services.AddTransient<ICharacterDescriptionService, CharacterDescriptionService>();
builder.Services.AddTransient<IGameMasterNoteService, GameMasterNoteService>();
builder.Services.AddTransient<IChapterService, ChapterService>();
builder.Services.AddTransient<IMapService, MapService>();
builder.Services.AddTransient<IDamageTypeService, DamageTypeService>();
builder.Services.AddTransient<IResistanceTypeService, ResistanceTypeService>();
builder.Services.AddTransient<IDamageResistanceService, DamageResistanceService>();
builder.Services.AddTransient<IPlayerCharacterSpellService, PlayerCharacterSpellService>();
builder.Services.AddTransient<IPlayerCharacterFeatService, PlayerCharacterFeatService>();
builder.Services.AddTransient<IPlayerCharacterLanguageService, PlayerCharacterLanguageService>();
builder.Services.AddTransient<IPlayerCharacterEquipmentService, PlayerCharacterEquipmentService>();
builder.Services.AddTransient<IMonsterLanguageService, MonsterLanguageService>();

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
