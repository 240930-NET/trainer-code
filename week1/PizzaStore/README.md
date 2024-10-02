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