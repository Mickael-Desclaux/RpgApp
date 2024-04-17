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
