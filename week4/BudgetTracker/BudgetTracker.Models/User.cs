namespace BudgetTracker.Models;
public class User{

    public int UserId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    //Set up relationship with Expense
    public List<Expense> Expenses { get; set; } = new List<Expense>();
}