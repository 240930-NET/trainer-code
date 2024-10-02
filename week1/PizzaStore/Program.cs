namespace PizzaStore;

class Program
{
    static void Main(string[] args)
    {
       PineapplePizza newPizzaOrder = new PineapplePizza{pizzaName = "Pineapple Pizza"};
       BBQPizza newBBQPizzaOrder = new BBQPizza{pizzaName = "BBQ Pizza"};

       newPizzaOrder.BakePizza();
       newBBQPizzaOrder.BakePizza();

       //Check our toppings
       newPizzaOrder.AddToppings();
       newBBQPizzaOrder.AddToppings();

       //Add proteing
       newPizzaOrder.addProtein();
       newBBQPizzaOrder.addProtein();
    }
}
