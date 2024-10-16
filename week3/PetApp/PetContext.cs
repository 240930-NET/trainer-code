using Microsoft.EntityFrameworkCore; 

public class PetContext : DbContext{

    // Add constructor to avoid error of Unable to create a 'DbContext' of type ''
    public PetContext(DbContextOptions<PetContext> options) : base(options){}
    public DbSet<Pet> Pets {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder){



        // Seed initial data to the database
        modelBuilder.Entity<Pet>().HasData(

            new Pet { PetId = 1, Name = "Cooper", Type = "Dog", Age = 3},
            new Pet { PetId = 2, Name = "Marty", Type = "Cat", Age = 2},
            new Pet { PetId = 3, Name = "Ermak", Type = "Cat", Age = 13},
            new Pet { PetId = 4, Name = "Loki", Type = "Dog", Age = 7}

        );
    }

}