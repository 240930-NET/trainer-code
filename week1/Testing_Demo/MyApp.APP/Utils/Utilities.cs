using System.Configuration.Assemblies;

namespace MyApp.APP.Utils;

public class Utilities
{
    public static void Hello()
    {
        Console.WriteLine("Hello");
    }

    public static int UserChoice(string? choice)
    {
        try
        {
            return Convert.ToInt32(choice);
        } catch(Exception)
        {
            Console.WriteLine("The selection you made did was invalid. Try again!");
            return -1;
        }
    }

    public static bool IsEven(int number)
    {
        if(number % 2 == 0) return true;
        return false;
    }

    public static void AddName(string name, List<string> nameList)
    {
        nameList.Add(name);
    }

    public static void ListNames(List<string> nameList)
    {
        foreach(var name in nameList)
        {
            Console.WriteLine(name);
        }
    }
}