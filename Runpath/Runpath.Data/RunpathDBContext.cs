using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Runpath.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Runpath.Data
{
    /// <summary>
    /// Database Context for Entity Framework
    /// </summary>
    public class RunpathDBContext : DbContext
    {
        private static bool _created = false;

        public RunpathDBContext(DbContextOptions options) : base(options)
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
                Database.Migrate();
            }
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlite("Filename=Runpath.db");
                var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "Runpath.db" };
                var connectionString = connectionStringBuilder.ToString();
                var connection = new SqliteConnection(connectionString);

                optionsBuilder.UseSqlite(connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable("Users");

            builder.Entity<User>().HasData(
                new User { UserID = 1, UserName = "Test" }
              );

        }
    }
}
