﻿using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace PostgresTest.Infra
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecast>()
                .HasNoKey();
        }

        public DbSet<PhotoInfmation> PhotoInfmation { get; set; }
        public DbSet<WeatherForecast> WeatherForecast { get; set; }
    }
}
