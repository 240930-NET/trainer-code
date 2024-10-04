using System.Collections.Generic;

namespace guessGame;

class Program
{
    static void Main(string[] args)
    {   
        Dictionary<int, string> gameData = new Dictionary<int, string>();
        //Pass gameData dictionary to my game object
        Game myNewGame = new Game(gameData);
        
        myNewGame.Greeting();
        for(int i = 0; i < 3; i++){
            myNewGame.StartGame();
        }
        Console.WriteLine("Scores:");
        myNewGame.ShowScoreTable();
        myNewGame.ShowWonGame();
    }
}
