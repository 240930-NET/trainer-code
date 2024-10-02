class BBQPizza : Pizza, IPizza{
    
    //Implement required method from the parent class
    public override void AddToppings(){
        Console.WriteLine("Add: BBQ ");
        Console.WriteLine("Add: Tomatoes ");

    }

    public void addProtein(){
        Console.WriteLine("Add: Ham");
    } 
}