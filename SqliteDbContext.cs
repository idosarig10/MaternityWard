using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MaternityWard
{
    class SqliteDbContext : DbContext
    {
        public DbSet<Worker> Worker { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=WorkersData.db");
        }
    }
}
