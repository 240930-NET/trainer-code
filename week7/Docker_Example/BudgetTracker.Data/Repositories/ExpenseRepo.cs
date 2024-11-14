using Microsoft.EntityFrameworkCore;
using BudgetTracker.Models;


namespace BudgetTracker.Data;

public class ExpenseRepo : IExpenseRepo{

    private readonly BudgetContext _context; // this holds reference to the context

    public ExpenseRepo(BudgetContext context){
        _context = context;
    }

    //CRUD methods
    public List<Expense> GetAllExpenses(){
        return _context.Expenses.ToList();
    }
    public Expense getExpenseById(int id){
        return _context.Expenses.Find(id);
    }

    // Add new expense
    public void addExpense(Expense expense){

        _context.Expenses.Add(expense);
        _context.SaveChanges();
    }
    // Update existing expense
    public void updateExpense(Expense expense){
        _context.Expenses.Update(expense);
        _context.SaveChanges();
    }
    // Delete expense
    public void deleteExpense(Expense expense){
        _context.Expenses.Remove(expense);
        _context.SaveChanges();
    }
}

