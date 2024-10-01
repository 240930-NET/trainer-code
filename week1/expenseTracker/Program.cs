
class Program{

    public static void Main(string[] args){

        //Greet user
        Menu.Greetings(); 

        //Display Menu options
        Menu.DisplayUserOptions();

        int selectedOption = Menu.GetUserInput();

        switch(selectedOption){
            case 1:
                Console.WriteLine("You selected to add a new Expense");
                break;
            case 2:
                Console.WriteLine("You selected to Edit an Expense");
                break;
            case 3:
                Console.WriteLine("You selected to Delete an Expense");
                break;
            case 4:
                Console.WriteLine("You selected to Display All");
                break;
        }

    }


}