class VeggiePizza : Pizza{

    public override void AddToppings(){
        Console.WriteLine("Add Tomatoes");
    }

     public override void DisplayPizzaData(){
        Console.WriteLine("Here is the pizza:\n");
        Console.WriteLine("Name: " + pizzaName);
        Console.WriteLine("Description: " + getDescription());

    }


}