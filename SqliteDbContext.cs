using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace MaternityWard
{
    class SqliteDbContext : DbContext
    {
        public DbSet<Worker> Worker { get; set; }
        public DbSet<Prices> Prices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //string path = ConfigurationManager.ConnectionStrings["WorkersData"].ConnectionString;
            options.UseSqlite(@"DataSource=C:\Users\idosarig\source\repos\MaternityWard\WorkersData.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
