using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace MaternityWard
{
    class SqliteDbContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<RankBonus> Bonuses { get; set; }
        public DbSet<MonthWorkHours> MonthWorkHours { get; set; }



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
