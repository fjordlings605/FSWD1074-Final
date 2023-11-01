using burble_api.Models;
using Microsoft.EntityFrameworkCore;

namespace burble_api.Migrations;

public class BurbleDbContext : DbContext 
{
    public DbSet<Burble> Burble { get; set; }
    public DbSet<User> Users { get; set; }
    public BurbleDbContext(DbContextOptions<BurbleDbContext> options) : base(options){

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Burble>(entity => {
            entity.HasKey(e => e.BurbId);
            entity.Property(e => e.Username);
            entity.Property(e => e.TimeDate);
            entity.Property(e => e.BurbTxt);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId);
            entity.Property(e => e.Username).IsRequired();
            entity.HasIndex(x => x.Username).IsUnique();
            entity.Property(e => e.Password).IsRequired();
            entity.Property(e => e.FirstName).IsRequired();
            entity.Property(e => e.LastName).IsRequired();
            entity.Property(e => e.City);
            entity.Property(e => e.State);
        });

        modelBuilder.Entity<Burble>().HasData(
            new Burble {
                BurbId = "1",
                Username = "Default01",
                TimeDate = DateTime.Now,
                BurbTxt = "First Burb Ever!  Woot Woot!"
            },
            new Burble {
                BurbId = "2",
                Username = "Default02",
                TimeDate = DateTime.Now,
                BurbTxt = "Second Burb, Great as the First!  BlblBlblbrblrblbrbrlbrbbrbll!"
            }
        );
    }
}