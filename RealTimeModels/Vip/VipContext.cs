using Microsoft.EntityFrameworkCore;

namespace RealTimeModels.Vip;

public class VipContext : DbContext
{
    public DbSet<Station> Stations => Set<Station>();
    public DbSet<RealTimeEntry> RealTimeEntries => Set<RealTimeEntry>();
    public DbSet<Alert> Alerts => Set<Alert>();
    public DbSet<Route> Routes => Set<Route>();
    public DbSet<Vehicle> Vehicles => Set<Vehicle>();

    private string? ConnectionString { get; set; }

    public VipContext(string? connectionString = null)
    {
        ConnectionString = connectionString;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var stationEntity = modelBuilder.Entity<Station>();
        stationEntity
            .HasMany(station => station.Actual)
            .WithOne();
        stationEntity
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(ConnectionString ?? "Host=127.0.0.1;Database=transit_vip;Username=postgres;Password=mysecretpassword");
        options.EnableDetailedErrors();
        options.EnableSensitiveDataLogging();
    }
}
