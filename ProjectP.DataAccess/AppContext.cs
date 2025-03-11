using Microsoft.EntityFrameworkCore;
using ProjectP.DataAccess.Models;

namespace ProjectP.DataAccess;

public class AppContext(DbContextOptions<AppContext> options) : DbContext(options)
{
    public DbSet<Event> Events { get; set; }
    public DbSet<Member> Members { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Event>()
            .HasKey(ev => ev.Id);
        base.OnModelCreating(modelBuilder);
    }
}
