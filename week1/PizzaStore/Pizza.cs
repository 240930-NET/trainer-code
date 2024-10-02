abstract class Pizza{
    
    // encapsulation - achieved through using private fields, and public methods

    public string pizzaName {get;set;}
    public string crust {get; set;} 
    public string[] toppings {get; set;}
    public string size {get; set;}
    public string description {get;set;}

    public void BakePizza(){
        Console.WriteLine("Baking..." + pizzaName);
    }

    // Keyword abstract means we HAVE to create implementation in our subclasses
    public abstract void AddToppings();

    


}