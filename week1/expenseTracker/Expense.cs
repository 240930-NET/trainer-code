public class Expense{

    public string? Name {get; set; }
    public double? Amount {get; set; }
    public string? Description {get; set; }

    public Expense(){
        
    }
    public Expense(string name, double amount, string description){
        Name = name;
        Amount = amount;
        Description = description;
    }

    public void PrintExpenseDetails(){
        Console.WriteLine($"Name: {Name}, Amount: {Amount}, Description: {Description}\n");
    }
}