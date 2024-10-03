namespace MyApp.APP;

public class Menu
{
    public static void DisplayBanner(TextWriter textWriter)
    {
        textWriter.WriteLine(
            " _____     _     _______             _                \n" +        
            "|  __ \\   | |   |__   __|           | |              \n" +
            "| |__) |__| |_     | |_ __ __ _  ___| | _____ _ __    \n" +
            "|  ___/ _ \\ __|    | | '__/ _` |/ __| |/ / _ \\ '__| \n" +
            "| |  |  __/ |_     | | | | (_| | (__|   <  __/ |      \n" +
            "|_|   \\___|\\__|    |_|_|  \\__,_|\\___|_|\\_\\___|_|  "                                  
        );
        
        textWriter.WriteLine("Hello, welcome to Pet Tracker!\n");
    }

    public static void DisplayMenu()
    {
        throw new NotImplementedException();
    }
}