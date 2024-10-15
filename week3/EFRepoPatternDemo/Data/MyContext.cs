using Microsoft.EntityFrameworkCore;
using EFDemo.Models;
using EFDemo;


namespace EFDemo.Data;
public class MyContext : DbContext {
    public DbSet<User> Users { get; set; } // define DBSet of user
    public DbSet<Donation> Donations { get; set; } // define DBSet of product

    //public MyContext(DbContextOptions<MyContext> options) : base(options) {}
    //public MyContext(){}

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {   
        string ConnectionString = File.ReadAllText("./connectionString.txt");
        optionsBuilder.UseSqlServer(ConnectionString); 
    }

}