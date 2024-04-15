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

//Add Repositories
builder.Services.AddScoped<IRepository<Spell>, Repository<Spell>>();
builder.Services.AddScoped<IRepository<PlayerCharacter>, Repository<PlayerCharacter>>();
builder.Services.AddScoped<IRepository<DiceType>, Repository<DiceType>>();
builder.Services.AddScoped<IRepository<PlayerStat>, Repository<PlayerStat>>();
builder.Services.AddScoped<IRepository<NonPlayerCharacter>, Repository<NonPlayerCharacter>>();

//Add Services
builder.Services.AddTransient<ISpellService, SpellService>();
builder.Services.AddTransient<IPlayerCharacterService, PlayerCharacterService>();
builder.Services.AddTransient<IDiceTypeService, DiceTypeService>();
builder.Services.AddTransient<IPlayerStatService, PlayerStatService>();
builder.Services.AddTransient<INonPlayerCharacterService, NonPlayerCharacterService>();

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
