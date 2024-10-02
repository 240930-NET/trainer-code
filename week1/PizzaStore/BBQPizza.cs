class BBQPizza : Pizza, IPizza{
    
    //Implement required method from the parent class
    public override void AddToppings(){
        Console.WriteLine("Add: BBQ ");
        Console.WriteLine("Add: Tomatoes ");

    }

    public void addProtein(){
        Console.WriteLine("Add: Ham");
    } 

     public override void DisplayPizzaData(){
        Console.WriteLine("Here is the pizza:\n");
        Console.WriteLine("Name: " + pizzaName);
        Console.WriteLine("Description: " + getDescription());

    }
}