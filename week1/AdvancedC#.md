## Enums (short for enumerations) 

This is a value type that allows you to define a set of named constants

```csharp

public enum DaysOfWeek{

    Monday, // 0
    Tuesday, // 1
    Wednesday, // 2
    Thursday, //3
    Friday, // 4
    Saturday, // 5
    Sunday, //5
}

DaysOfWeek today = DaysOfWeek.Friday;

```

### Struct (short for structure)

 Struct is a value type that used to define a data structure so it is contains related data.

```csharp
public struct Point {

    public int X;
    public int Y;

    public Point(int x, int y){
        X = x; 
        Y = y;
    }

    public void Display(){
        Console.WriteLine($"Example " + {X});
    }
}

```

#### Struct vs Class
- Struct is a value type
- Structs CAN'T inherit from other structs
- It is stored in Stack

Use it when you need a lightweight structure that does not require to have inheritance.


## ? and ?? operators

- Null-Conditional operator ```(?)``` - allows safely access members/methods that might be null (so we will not have 1000 warnings in our console)

```csharp

var result = object?.SomePropertyOfTheObject; // so to make nullable our result and be safe, we add ? operator

//Another example
class Somethings{

    public string? myNullableProperty;
}

```

- **Null-Coalescing Operator** ```??```
This one is assigning a default value to a variable if case the initial value is null.

```csharp
var something = expression ?? "This is my default value is expression is null";

int muInteger = expression ?? 15; // If expression is null myInteger will be 0;

```

### Upcasting and Downcasting

**Upcasting** - conversion from subclass(child) to parent.
**Downcasting** - the opposite of the above. (From base to child)

```csharp

//Parent class
public class Animal{
    public virtual void Speak(){
        Console.WriteLine("Something");
    }
}

public class Dog : Animal{

     public override void Speak(){
        Console.WriteLine("Speaking");
    }

    public void Bark(){
         Console.WriteLine("Bark!");
    }
}

//Upcasting example
Animal myAnimal = new Dog(); // Upcasting 

if(myAnimal is Dog myDog){
    myDog.Bark(); // now you can access the methods of Dog class
}

myAnimal.Bark(); // it will not work, because Animal does not have Bark method


```