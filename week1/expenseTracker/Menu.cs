static class Menu{

    //Greet user
    public static void Greetings(){
        Console.WriteLine("Hello user, this is a financial app!");
        Console.WriteLine("Select one of the following:\n");
    }

    // Display options
    public static void DisplayUserOptions(){

        Console.WriteLine("1. Add a new Expense");
        Console.WriteLine("2. Edit an Expense");
        Console.WriteLine("3. Delete an Expense");
        Console.WriteLine("4. Display All");
        Console.WriteLine("9. Leave the app");
    }

    //Get user input 
    public static int GetUserInput(){
        Console.WriteLine("Type the option number");

        string? userInput = Console.ReadLine();

        //Convert user input string to int

        try{
            int i = Int32.Parse(userInput);
            return i;
        }
        catch(Exception er){
            Console.WriteLine(er.Message);
            return 0;
        }
        finally{
            Console.WriteLine("This is supposed to excecute anyway!");
        }


       
    }


    // Get expense name
    public static string GetExpenseName(){

        Console.WriteLine("Type expense name you want to select: \n");
        string? expenseName = Console.ReadLine();
        return expenseName;
    }


    // Get details for a new/updated Expense
    public static Expense GetExpenseDetails(){

        Console.WriteLine("Type expense name: \n");
        string? expenseName = Console.ReadLine();

        Console.WriteLine("Type expense amount: \n");
        string? expenseAmount = Console.ReadLine();

        double expenseAmountDouble = Double.Parse(expenseAmount);

        Console.WriteLine("Type expense Description: \n");
        string? expenseDescription = Console.ReadLine();


        return new Expense(expenseName, expenseAmountDouble, expenseDescription);
    }


}