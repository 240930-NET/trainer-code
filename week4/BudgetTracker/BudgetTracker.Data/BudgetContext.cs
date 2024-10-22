using BudgetTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetTracker.Data;


public class BudgetContext : DbContext
{

    //Set up constructor

    public BudgetContext() : base(){}
    public BudgetContext(DbContextOptions<BudgetContext> options) : base(options) {} // for connection string and etc configuration

    public DbSet<Expense> Expenses { get; set;}
    public DbSet<User> Users { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
        .HasMany(u => u.Expenses) // user has many Expenses
        .WithOne() // since we have no navigation property it is empty
        .HasForeignKey(e => e.UserId) // and has foreign key UserId
        .OnDelete(DeleteBehavior.Cascade); // remove expenses if user is deleted
    }

}
