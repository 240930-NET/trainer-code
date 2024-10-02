
// : -> means PineapplePizza inherits from Pizza
class PineapplePizza : Pizza, IPizza{


    //Implement required method from the parent class
    public override void AddToppings(){
        Console.WriteLine("Add: pineapple");
    }

        public void addProtein(){
        Console.WriteLine("Add: Ham");
    } 

    // Overriding parent's method and demonstrate Polymorphism
    public override void CutPizza(){
        Console.WriteLine("Cutting " + pizzaName);
    }

    //Method Overloading
    public void AddToppings(string veggies, string protein){
        Console.WriteLine($"Adding: {veggies} and {protein}");
    }

    //Display Pizza Data
    public override void DisplayPizzaData(){
        Console.WriteLine("Here is the pizza:\n");
        Console.WriteLine("Name: " + pizzaName);
        Console.WriteLine("Description: " + getDescription());
        Console.WriteLine("Crust" + crust);
    }

}