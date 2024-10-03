
public class Program{

    public static void Main(string[] args){

        List<Expense> expenses = Data.DeserializeExpenses();
        //expenses = ;
        
        //Add initial Data
        //expenses.Add(new Expense("Gas", 34.20, "Shell Gas"));
        //expenses.Add(new Expense("Electricity", 184.20, "Terrible Winter"));

        //Greet user
        Menu.Greetings(); 

        //Display Menu options
        Menu.DisplayUserOptions();

        int selectedOption = Menu.GetUserInput();

        while(selectedOption != 9){
              switch(selectedOption){
            case 1:
                Logic.AddExpenses(expenses);
                break;
            case 2:
              Logic.EditExpenses(expenses);
                break;
            case 3:
               Logic.RemoveExpenses(expenses);
                break;
            case 4:
                 Console.WriteLine("Here is the list of your expenses:\n");
                 Logic.DisplayExpenses(expenses);
                 break;
            case 5:
                Console.WriteLine("Save your expense information");
                Logic.SaveToFile(expenses);
                break;
            }
            Menu.DisplayUserOptions();
            selectedOption = Menu.GetUserInput();
        }
      

    }


}