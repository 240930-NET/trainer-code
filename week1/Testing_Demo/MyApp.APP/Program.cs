//Why and how we use properties
// Point myP = new();

        // myP.Set_X(45);
        // int varX = myP.Get_X();

        // myP.Y = -466;
        // int varY = myP.Y;

        // Console.WriteLine(myP);

namespace MyApp.APP;

using MyApp.APP.Utils;
using Horoscope;

class Program
{
    static void Main(string[] args)
    {
        var zodiacSign = Zodiac.GetZodiacSignForDate(new DateTime(1992, 10, 14));

        Console.WriteLine(zodiacSign.ZodiacName);        
        
        List<string> names = [];

        Menu.DisplayBanner(Console.Out);
        
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
                    Utilities.ListNamesDI(names, Console.Out);
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
