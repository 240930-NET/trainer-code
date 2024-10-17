using BudgetTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetTracker.Data;


public class BudgetContext : DbContext
{

    //Set up constructor

    public BudgetContext() : base(){}
    public BudgetContext(DbContextOptions<BudgetContext> options) : base(options) {} // for connection string and etc configuration

    public DbSet<Expense> Expenses { get; set;}

}
