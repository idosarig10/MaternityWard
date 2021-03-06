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




        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string path = ConfigurationManager.ConnectionStrings["WorkersData"].ConnectionString;
            options.UseSqlite(path);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkerTypeRank>().HasKey(wr => new { wr.WorkerType, wr.Rank });
        }
    }
}
