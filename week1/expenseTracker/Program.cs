
class Program{

    public static void Main(string[] args){

        List<Expense> expenses = new List<Expense>();
        
        //Add initial Data
        expenses.Add(new Expense("Gas", 34.20, "Shell Gas"));
        expenses.Add(new Expense("Electricity", 184.20, "Terrible Winter"));

        //Greet user
        Menu.Greetings(); 

        //Display Menu options
        Menu.DisplayUserOptions();

        int selectedOption = Menu.GetUserInput();

        switch(selectedOption){
            case 1:

                //Add a new expense
                Expense meNewExpense = Menu.GetExpenseDetails();
                expenses.Add(meNewExpense);
                Console.WriteLine("Expense added");

                  foreach(Expense expense in expenses){
                    expense.PrintExpenseDetails();
                }

                break;

            case 2:
                Console.WriteLine("You selected to Edit an Expense");

                string selectedName = Menu.GetExpenseName();
                var selectedExpense = expenses.Find( myexpense => myexpense.Name == selectedName); // use lambda

                Expense newExpenseData = Menu.GetExpenseDetails();
                
                selectedExpense.Name = newExpenseData.Name;
                selectedExpense.Amount = newExpenseData.Amount;
                selectedExpense.Description = newExpenseData.Description;

                Console.WriteLine("Expense was replaced");

                foreach(Expense expense in expenses){
                    expense.PrintExpenseDetails();
                }

                break;
            case 3:
                Console.WriteLine("You selected to Delete an Expense");

                string selectedNametoRemove = Menu.GetExpenseName();

                var selectedExpensetoDelete = expenses.Find( myexpense => myexpense.Name == selectedNametoRemove); // use lambda
                expenses.Remove(selectedExpensetoDelete);
                
                foreach(Expense expense in expenses){
                    expense.PrintExpenseDetails();
                }

                break;
            case 4:
                 Console.WriteLine("Here is the list of your expenses");
                //Loop through our expense List
                foreach(Expense expense in expenses){
                    expense.PrintExpenseDetails();
                }

                break;
        }

    }


}