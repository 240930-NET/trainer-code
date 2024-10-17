namespace BudgetTracker.Models;

public class Expense
{   
    public int ExpenseId { get; set; }
    public string? ExpenseName {get; set; }
    public double? ExpenseAmount {get; set; }
    public string? ExpenseDescription {get; set; }

    public Expense(){
        
    }

    public void PrintExpenseDetails(){
        Console.WriteLine($"Name: {ExpenseName}, Amount: {ExpenseAmount}, Description: {ExpenseDescription}\n");
    }
}
