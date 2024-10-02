abstract class Pizza{
    
    // encapsulation - achieved through using private fields, and public methods

    public string pizzaName {get;set;}
    protected string crust = "Default Crust";
    public string[] toppings {get; set;}
    public string size {get; set;}
    private string _description = "Default Description";


    //Interfaces to interact with _description fields
    public void setDescription(string description){
        this._description = description;
    }

    public string getDescription(){
        return this._description;
    }


    public void BakePizza(){
        Console.WriteLine("Baking..." + pizzaName);
    }

    // Keyword abstract means we HAVE to create implementation in our subclasses
    public abstract void AddToppings();

    public abstract void DisplayPizzaData();

    //So we mark this method as virtual so we CAN override it in our subclass 
    public virtual void CutPizza(){
        Console.WriteLine("Cutting Pizza...");
    }



}