#### Inheritance 
- Allows one class (subclass/child) to inherit the properties and behaviors of another (superclass/base class).
Promotes code reuse. **A class can inherit ONLY from one class.**

```csharp
class PineApplePizza : Pizza {
    //PineApplePizza is a sublclass of Pizza
}  
```

#### Abstraction

- It means hiding all complex details and only showing the necessary one. In C#, it is achieved by using interfaces and abstract classes.

We can implement as many interfaces as we want, but we can inherit only one class.

```csharp

interface IPizza{
    public void AddProtein(); // only method signature here, no implementation, have to implement in a class
}

//or 

abstract class Pizza{

    public abstract void AddToppings(); // // only method signature here, no implementation, have to implement in a subclass
}


```


If you have 2 interfaces with the same method names, use explicit method calls.

```cs
public class SampleClass : IControl, ISurface
{
    void IControl.Paint()
    {
        System.Console.WriteLine("IControl.Paint");
    }
    void ISurface.Paint()
    {
        System.Console.WriteLine("ISurface.Paint");
    }
}

```

#### Polymorphism 

It means "many shapes", it is achieved by using method **overriding** and method **overloading**. 


```csharp

//Parent class Pizza.cs

    public virtual void CutPizza(){
        Console.WriteLine("Cutting Pizza...");
    }


//Child class PineApplePizza.cs 

    public override void CutPizza(){ // overriding parent's implementation
        Console.WriteLine("Cutting " + pizzaName);
    }

        //Method Overloading
    public void AddToppings(){
        Console.WriteLine($"Adding: toppings");
    }

    public void AddToppings(string veggies, string protein){
        Console.WriteLine($"Adding: {veggies} and {protein}");
    }

```

### Encapsulation

Putting all related data together in one single class (or unit) and it helps us to hide important details. We also provide mechanism (getters and setters ) to interact with out properties. 

Access modifiers: 

- private (the most restricted one)
- protected (only class itself and its children can access it)
- internal (pne assembly)
- public (all can see it)