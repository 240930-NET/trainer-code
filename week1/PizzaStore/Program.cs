namespace PizzaStore;

class Program
{
    static void Main(string[] args)
    {
       PineapplePizza newPizzaOrder = new PineapplePizza{pizzaName = "Pineapple Pizza"};
      // BBQPizza newBBQPizzaOrder = new BBQPizza{pizzaName = "BBQ Pizza"};

       //newPizzaOrder.BakePizza();
       //newBBQPizzaOrder.BakePizza();

       //Check our toppings
       //newPizzaOrder.AddToppings();
       //newBBQPizzaOrder.AddToppings();

       //Add proteing
       //newPizzaOrder.addProtein();
       //newBBQPizzaOrder.addProtein();

        /*
       //Test our overriden method
       Console.WriteLine("Pineapple Pizza executes cutPizza\n");
       newPizzaOrder.CutPizza();


       Console.WriteLine("BBQ Pizza executes cutPizza\n");
       newBBQPizzaOrder.CutPizza();


       //Run overloaded method
        newPizzaOrder.AddToppings("pineapple", "ham");
        */
        Pizza mypineapplePizza = new PineapplePizza{
            pizzaName = "Pineapple pizza"}; // another example of a polymorhpism (dynamic)
        //mypineapplePizza.AddToppings();
        mypineapplePizza.DisplayPizzaData();

    }


}
