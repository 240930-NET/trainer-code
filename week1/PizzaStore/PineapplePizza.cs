
// : -> means PineapplePizza inherits from Pizza
class PineapplePizza : Pizza, IPizza{


    //Implement required method from the parent class
    public override void AddToppings(){
        Console.WriteLine("Add: pineapple");
    }

        public void addProtein(){
        Console.WriteLine("Add: Ham");
    } 
}