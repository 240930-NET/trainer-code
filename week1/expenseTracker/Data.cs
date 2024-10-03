using System.Text.Json; // to be able to access Serializer
public static class Data{


    // Asynchronous helps us to work with blocking operations such us File i/o, 
    //so we can still work on other things while waiting for the end of operation
    //Async keyword marks the method as asynchronous
    public static async Task SerializeDataAsync(List<Expense> expenses){

        string expenseList = JsonSerializer.Serialize(expenses);

        try{

            using(StreamWriter writer = File.CreateText("expenses.txt")){
                await writer.WriteAsync(expenseList);
            }
        }
        catch(Exception e){
            Console.WriteLine($"Could not save changes: {e.Message}");
        }
    }


    //Deserialize our data

    public static List<Expense> DeserializeExpenses(){
        Console.WriteLine("TEST");
        try{
            using(StreamReader reader = File.OpenText("expenses.txt")){
                string jsonString =  reader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Expense>>(jsonString);
            }
        }

        catch(Exception e){
            Console.WriteLine($"Could not load data: {e.Message}");
            return new List<Expense>();
        }
    }
}