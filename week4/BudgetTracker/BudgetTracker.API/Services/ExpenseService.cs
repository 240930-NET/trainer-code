using BudgetTracker.Data;
using BudgetTracker.Models;

namespace BudgetTracker.API;

public class ExpenseService : IExpenseService {

    private readonly IExpenseRepo _expenseRepo;

    // dependency injection  to our IExpenseRepo interface  in the constructor  of ExpenseService class  (constructor injection)  which is the recommended way of doing dependency injection in .NET Core.  It injects an instance of IExpenseRepo into the constructor of ExpenseService.  This makes our ExpenseService class more reusable and easier to test.  This way, we can easily switch out the implementation of IExpenseRepo with a different one in the future if needed.  This is a best practice in .NET Core.  It's a good idea to use constructor injection when you can, as it makes your code more flexible and easier to test.  However, in this simple example, we are not using constructor injection, but rather dependency injection.   However, it's a good idea to use constructor injection in most cases.  
    //It's also a good idea to use interfaces for your dependencies, so you can easily
    public ExpenseService(IExpenseRepo expenseRepo){
        _expenseRepo =  expenseRepo; 
    }

      // Get add Expenses 
    public List<Expense> GetAllExpenses(){

        List<Expense> result = _expenseRepo.getAllExpenses();
        if(result.Count == 0){
            return null;
        }
        else{
            return result;
        }
        
    }

    // Get Expenses by Id
    public Expense GetExpenseById(int id){

        Expense expense = _expenseRepo.getExpenseById(id);
        if(expense != null){
            return expense;
        }
        else{
            return null;
        }
    }

     // Add new Expense
    public string AddExpense(Expense expense){

        if(expense.ExpenseName != null && expense.ExpenseAmount > 0){
            _expenseRepo.addExpense(expense);
            return $"Expense ${expense.ExpenseName} added successfully!";
        }
        else{
            throw new Exception("Invalid Expense. Please check name or amount!");
        }
    }

    // Update Expense
    public Expense EditExpense(Expense expense){

        //Find our expense by Id
        Expense searchedExpense = _expenseRepo.getExpenseById(expense.ExpenseId);
        if(searchedExpense != null){
             //Update it with new values 
            if(expense.ExpenseName != null && expense.ExpenseAmount > 0 ){
                searchedExpense.ExpenseName = expense.ExpenseName;
                searchedExpense.ExpenseAmount = expense.ExpenseAmount;
                searchedExpense.ExpenseDescription = expense.ExpenseDescription;

                //Pass it to our Expense Repository
                _expenseRepo.updateExpense(searchedExpense);
                return searchedExpense;
            }
            else{
                throw new Exception("Invalid Expense. Please check name or amount!");
            }
        }

            throw new Exception("Invalid Expense. Does not exist.");
       
       
    }

    // Delete Expense
    public string DeleteExpense(int id){

        //Find by Id
        Expense searchedExpense = _expenseRepo.getExpenseById(id);
        //Validate 
        if(searchedExpense != null){
            //Delete
            _expenseRepo.deleteExpense(searchedExpense);
            return $"Expense with id {id} deleted successfully!";
        }
        else{
            throw new Exception($"This expense with id {id} does not exist");
        }

    }
}