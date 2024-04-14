﻿using Microsoft.EntityFrameworkCore;
using RpgApp.Api.Entity;

namespace RpgApp.Api.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Spell> Spell { get; init; }
    }
}
