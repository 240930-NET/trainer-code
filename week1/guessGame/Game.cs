using System.Collections.Generic;

public class Game{

    public string? userName { get; set; } = "Anonymous";
    public Dictionary <int, string> scoreTable { get; set; }
    public int gameNumber { get; set; } = 0;


    public Game(Dictionary<int, string> scoreTable){
      
        this.scoreTable = scoreTable;
        
    }

    public void Greeting(){

        Console.WriteLine($"Hello {userName}! Welcome to the game!");
        Console.WriteLine("Type your username");
        userName = Console.ReadLine();
        Console.WriteLine($"Welcome {userName}");
        
    }

    public void StartGame(){

        Thread.Sleep(1000);
        Console.WriteLine("Computer is generating value...");

        Console.WriteLine("Type your guess...");

        //Call GenerateRandomNumber to get random number
        int computerNumber = GenerateRandomNumber();

        //Ask user to enter a number
        string userInput = Console.ReadLine();
        int convertedUserInput = Int32.Parse(userInput);

        Console.WriteLine("Comparing your and computer numbers...");

        // Comparing
        if(convertedUserInput == computerNumber){
            Console.WriteLine("Congratulations! You've won!");
            
            //Update our score table
            scoreTable.Add(gameNumber++, "Won");
        }
        else{
            Console.WriteLine("Sorry, you've lost. Computer number was: " + computerNumber);
            //Update our score table
            scoreTable.Add(gameNumber++, "Lost");
        }
        
    }

    public int GenerateRandomNumber(){
        Random RandomNumberGenerator = new Random();
        int RandomNumber = RandomNumberGenerator.Next(1, 10);
        return RandomNumber;
    }

    public void ShowScoreTable(){
        
        Console.WriteLine("Score Table:");
        foreach(var game in scoreTable){
            Console.WriteLine($"{game.Key}: {game.Value}");
        }
    }

    public void ShowWonGame(){

        // using LINQ syntax to get all games where user won and LINQ also uses lambdas functions
        var victoryGames = scoreTable.Where(x => x.Value == "Won").ToList(); // linq method
        Console.WriteLine("List of Games you won:");

        if(victoryGames.Count == 0){
             Console.WriteLine("No Games you won!");
        }
        else{
              foreach(var game in victoryGames){
            Console.WriteLine($"{game.Key}: {game.Value}");
        }
        }
      
    }
    


}