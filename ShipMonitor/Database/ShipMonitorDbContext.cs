using Microsoft.EntityFrameworkCore;
using ShipMonitor.Database.Entities;

namespace ShipMonitor.Database;

public class ShipMonitorDbContext : DbContext
{
    public const string MIGRATIONS_HISTORY_TABLE_NAME = "__EFMigrationsHistory";
    public const string SCHEMA_NAME = "ship_monitor";

    public DbSet<Ship> Ships { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
            return;

        optionsBuilder
            .UseNpgsql(builder =>
            {
                builder.MigrationsHistoryTable(MIGRATIONS_HISTORY_TABLE_NAME, SCHEMA_NAME);
            })
            .UseSnakeCaseNamingConvention();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(SCHEMA_NAME);

        modelBuilder.Entity<Ship>(e =>
        {
            e.HasIndex(p => p.Imo)
                .IsUnique();

            e.Property(p => p.Imo)
                .IsRequired();

            e.Property(p => p.ShipName)
                .IsRequired();
        });
    }
}
