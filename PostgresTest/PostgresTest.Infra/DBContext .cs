using Microsoft.EntityFrameworkCore;
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
            // PK : UserID
            modelBuilder.Entity<PhotoInfmationEntity>()
           .HasKey(c => c.UserID);
            // No Key
            modelBuilder.Entity<WeatherForecast>()
                .HasNoKey();
        }

        public DbSet<PhotoInfmationEntity> PhotoInfmation { get; set; }
        public DbSet<WeatherForecast> WeatherForecast { get; set; }
    }
}
