class MagicBall{

    public static void Main(string[] args){
        //run our function here

        Console.WriteLine("Welcome to the MagicBall");
        Console.WriteLine("Ask your question and I'll help you find the answer");

        string? userInput = Console.ReadLine();

        while(string.IsNullOrEmpty(userInput)){
            Console.WriteLine("Not valid user input");
            userInput = Console.ReadLine();
        }
        
            string? answer = GetMagicAnswer();
            Console.WriteLine($"The Magic Ball says: {answer}");
        
    }


    /*
        Select and return the answer
    */

    public static string GetMagicAnswer(){

        string[] predictions = {
            "You will receive everything you want!",
            "You will have a great day ahead!",
            "You will find a new friend!",
            "You will have a happy life!",
            "You will be rich and famous!",
            "You will be able to achieve great things!",
            "You will feel happy and fulfilled!"
        };

    
        // Create a new instance of the Random class
        Random numberGenerator = new Random();
        int randomIndex = numberGenerator.Next(predictions.Length);

        return predictions[randomIndex];

    }

}