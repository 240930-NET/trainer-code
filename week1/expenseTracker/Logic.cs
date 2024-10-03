//This class is responsible for handling business logic of our crud operations

public static class Logic{

    //Display all expenses 
    public static void DisplayExpenses(List<Expense> expenseList){

        if(expenseList.Count > 0){
            foreach(Expense ex in expenseList){
                ex.PrintExpenseDetails();
            }
        }
        else{
            Console.WriteLine("No expenses found.");
            return;
        }
    }

    // Add new 
    public static void AddExpenses(List<Expense> expenseList){
        //Add a new expense
        Expense meNewExpense = Menu.GetExpenseDetails();
        expenseList.Add(meNewExpense);
        Console.WriteLine("Expense added");
    }

    // Edit 
    public static void EditExpenses(List<Expense> expenseList){

        string selectedName = Menu.GetExpenseName();
        var selectedExpense = expenseList.Find( myexpense => myexpense.Name == selectedName); // use lambda

        if(selectedExpense != null){
             Expense newExpenseData = Menu.GetExpenseDetails();
            selectedExpense.Name = newExpenseData.Name;
            selectedExpense.Amount = newExpenseData.Amount;
            selectedExpense.Description = newExpenseData.Description;
            Console.WriteLine("Expense was replaced");
        }
        else{
             Console.WriteLine("Expense with that name was not found");
        }
       
    }

    // Remove
    public static void RemoveExpenses(List<Expense> expenseList){

    string selectedNametoRemove = Menu.GetExpenseName();

    var selectedExpensetoDelete = expenseList.Find( myexpense => myexpense.Name == selectedNametoRemove); // use lambda
    
    if(selectedExpensetoDelete != null){
         expenseList.Remove(selectedExpensetoDelete);
         Console.WriteLine("Expense was removed");
    }
    else{
        Console.WriteLine("Expense with that name wasn't found");
    }


    }


    //Save our data to file
    public static void SaveToFile(List<Expense> expenseList){
        Data.SerializeDataAsync(expenseList);
    }
}