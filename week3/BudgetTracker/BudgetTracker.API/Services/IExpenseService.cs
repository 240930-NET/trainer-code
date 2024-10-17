using BudgetTracker.Data;
using BudgetTracker.Models;

namespace BudgetTracker.API;

public interface IExpenseService {


    // Get add Expenses 
    public List<Expense> GetAllExpenses();

    // Get Expenses by Id
    public Expense GetExpenseById(int id);
}