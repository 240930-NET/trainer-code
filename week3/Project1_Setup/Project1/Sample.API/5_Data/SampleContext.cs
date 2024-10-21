using Microsoft.EntityFrameworkCore;
using Sample.API.Model;

namespace Sample.API.Data;

public partial class SampleContext : DbContext
{
    public SampleContext(){}
    public SampleContext(DbContextOptions<SampleContext> options) : base(options){}

    public virtual DbSet<Pet> Pets {get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pet>().HasData(
            new Pet {Id = 100, Name = "Rover", Type = "Dog"},
            new Pet {Id = 101, Name = "Chirp", Type = "Bird"}
        );

        // modelBuilder.Entity<Pet>(e =>
        //     {
        //      e.Property(e => e.Id)
        //      .ValueGeneratedNever()
        //      .HasColumnName("Hello");
        //     }
        // );
    }
}