using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using MaternityWard.Tables;

namespace MaternityWard
{
    class SqliteDbContext : DbContext
    {
        public DbSet<Bonus> Bonuses { get; set; }
        public DbSet<MonthActualWorkHours> MonthActualWorkHours { get; set; }
        public DbSet<MonthMinimunWorkHours> MonthMinimunWorkHours { get; set; }
        public DbSet<MonthWorkHours> MonthWorkHours { get; set; }
        public DbSet<HourlyRate> HourlyRates { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<WorkerRanks> WorkerRanks { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //string path = ConfigurationManager.ConnectionStrings["WorkersData"].ConnectionString;
            options.UseSqlite(@"DataSource=C:\Users\idosarig\source\repos\MaternityWard\WorkersData.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkerRanks>().HasKey(wr => new { wr.WorkerId, wr.Rank });
        }
    }
}
