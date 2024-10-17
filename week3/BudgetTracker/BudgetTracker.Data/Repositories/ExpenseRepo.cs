using Microsoft.EntityFrameworkCore;
using BudgetTracker.Models;


namespace BudgetTracker.Data;

public class ExpenseRepo : IExpenseRepo{

    private readonly BudgetContext _context; // this holds reference to the context

    public ExpenseRepo(BudgetContext context){
        _context = context;
    }

    //CRUD methods
    public List<Expense> getAllExpenses(){
        return _context.Expenses.ToList();
    }
    public Expense getExpenseById(int id){
        return _context.Expenses.Find(id);
    }

    // Implement:
    // Add new expense
    // Update existing expense
    // Delete expense
}

