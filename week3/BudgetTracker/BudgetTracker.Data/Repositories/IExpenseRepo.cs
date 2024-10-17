using BudgetTracker.Models;

namespace BudgetTracker.Data;

public interface IExpenseRepo {

    //For now two methods

    public List<Expense> getAllExpenses();
    public Expense getExpenseById(int id);


}