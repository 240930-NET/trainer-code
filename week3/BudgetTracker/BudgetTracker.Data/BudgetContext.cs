using BudgetTracker.Models;
//add EF

namespace BudgetTracker.Data;

public class BudgetContext : DbContext
{
    DbSet<Expense> expenses { get; set;}

    //Set up constructor

    public BudgetContext() : base(){};
    public BudgetContext(DbContextOptions<BudgetContext> options) : base(options) {} // for connection string and etc configuration
}
