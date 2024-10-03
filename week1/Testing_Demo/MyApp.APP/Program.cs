namespace MyApp.APP;

using MyApp.APP.Utils;

class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>();
        
        while(true)
        {            
            Console.WriteLine("1. Greetings.");
            Console.WriteLine("2. Check if number is even.");
            Console.WriteLine("3. Add name to list.");
            Console.WriteLine("4. List all the names.");
            Console.WriteLine("0. Exit.");
            
            int userSelection = Utilities.UserChoice(Console.ReadLine());          

            switch(userSelection)
            {
                case 1:
                    Console.WriteLine("Hello there!");
                    break;

                case 2:                 
                    Console.WriteLine("Enter a number to check for eveness.");
                    Console.WriteLine(Utilities.IsEven(Convert.ToInt32(Console.ReadLine())));
                    break;                

                case 3:
                    string name = Console.ReadLine()!;
                    if(name is not null) Utilities.AddName(name, names);
                    break;

                case 4:
                    Utilities.ListNames(names);
                    break;

                case 0:
                    Environment.Exit(0);
                    break;

                default:
                    break;
            }

            Console.WriteLine("\n\n");
        }
        
    }
}
