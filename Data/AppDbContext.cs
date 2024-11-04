using Carepulse_Backend.Entities;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // If needed, you can define specific behaviors for GUIDs here
        modelBuilder.Entity<Patient>().Property(p => p.Id).HasDefaultValueSql("NEWID()");
        modelBuilder.Entity<Doctor>().Property(d => d.Id).HasDefaultValueSql("NEWID()");
        modelBuilder.Entity<Appointment>().Property(a => a.Id).HasDefaultValueSql("NEWID()");
    }
}