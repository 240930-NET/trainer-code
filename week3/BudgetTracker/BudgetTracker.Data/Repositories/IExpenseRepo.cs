using BudgetTracker.Models;

namespace BudgetTracker.Data;

public interface IExpenseRepo {

    //For now two methods

    public List<Expense> getAllExpenses();
    public Expense getExpenseById(int id);

    //Add expense
    public void addExpense(Expense expense);

    //Delete expense
    public void deleteExpense(Expense expense);

    //Update expense
    public void updateExpense(Expense expense);


}