# C#

##  Build-in Data Types
C# provides several built-in data types that you can use to store different kinds of data. Here are some of the most commonly used types:


### **Integer Types**
- `int`: 32-bit signed integer. Example: `int age = 30;`
- `long`: 64-bit signed integer. Example: `long distance = 100000L;`
- `short`: 16-bit signed integer. Example: `short temperature = -10;`
- `byte`: 8-bit unsigned integer. Example: `byte level = 255;`

### **Floating-Point Types**
- `float`: 32-bit floating-point number. Example: `float height = 5.9F;`
- `double`: 64-bit floating-point number. Example: `double pi = 3.14159;`

### **Character and Boolean Types**
- `char`: 16-bit Unicode character. Example: `char initial = 'A';`
- `bool`: Represents Boolean values (`true` or `false`). Example: `bool isValid = true;`

### **String Type**
- `string`: Represents a sequence of characters. Example: `string name = "John Doe";`


## 2. Basic Operators

C# supports various operators to perform operations on data. Here are some basic operators:

### **Arithmetic Operators**
- `+` : Addition (e.g., `a + b`)
- `-` : Subtraction (e.g., `a - b`)
- `*` : Multiplication (e.g., `a * b`)
- `/` : Division (e.g., `a / b`)
- `%` : Modulus (e.g., `a % b`)

### **Comparison Operators**
- `==` : Equal to (e.g., `a == b`)
- `!=` : Not equal to (e.g., `a != b`)
- `>`  : Greater than (e.g., `a > b`)
- `<`  : Less than (e.g., `a < b`)
- `>=` : Greater than or equal to (e.g., `a >= b`)
- `<=` : Less than or equal to (e.g., `a <= b`)

### **Logical Operators**
- `&&` : Logical AND (e.g., `a && b`)
- `||` : Logical OR (e.g., `a || b`)
- `!`  : Logical NOT (e.g., `!a`)

### **Assignment Operators**
- `=`  : Assignment (e.g., `a = b`)
- `+=` : Addition assignment (e.g., `a += b`)
- `-=` : Subtraction assignment (e.g., `a -= b`)
- `*=` : Multiplication assignment (e.g., `a *= b`)
- `/=` : Division assignment (e.g., `a /= b`)

## 3. Input and Output on the Console

### **Output to the Console**

You can use `Console.WriteLine` to print output to the console:

```csharp
Console.WriteLine("Hello, World!");

//Read user input
string userInput = Console.ReadLine();
Console.WriteLine("You entered: " + userInput);
```

## 4. Conditional Statements


``if/else``

```cs
int age = 18;

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are a minor.");
}

//Switch
int day = 3;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}


```

## 5. Loops

```for``` Loop
The for loop is used to repeat a block of code a specified number of times:


```cs
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("i = " + i);
}
```

```While``` Loop
The while loop continues to execute as long as the specified condition is true:


```cs
int count = 0;

while (count < 5)
{
    Console.WriteLine("count = " + count);
    count++;
}
```
```do/while``` Loop
The do/while loop executes the block of code once before checking the condition:

```cs
int count = 0;

do
{
    Console.WriteLine("count = " + count);
    count++;
} while (count < 5);
```

```foreach ``` Loop
The foreach loop iterates over each element in a collection:



```cs
string[] names = { "Alice", "Bob", "Charlie" };

foreach (string name in names)
{
    Console.WriteLine(name);
}
```

## Type Conversion

Type conversion in C# allows you to convert data from one type to another. This is essential for ensuring that your program can handle different types of data correctly.


### **1.1. Implicit Conversion**

**Implicit** conversion is automatically performed by the compiler when converting from a **smaller data type to a larger** data type, as long as there is no risk of data loss. This is known as **widening conversion.**

**Example:**

```csharp
int intValue = 123;
double doubleValue = intValue; // Implicit conversion from int to double
```
### **1.2. Explicit Conversion**
Explicit conversion, or casting, is **required** when converting **from a larger data type to a smaller data type**, as this may result in data loss. You must use a cast operator to perform this conversion.

```cs
double doubleValue = 123.45;
int intValue = (int)doubleValue; // Explicit conversion from double to int

```

### Convert Class and Parsing


The **Convert** class provides methods to convert between types safely.



The **Parse** method of a type can be used to convert a **string representation of a number to its numeric type.**

```cs
string numberString = "123";
int intValue = Convert.ToInt32(numberString); // Convert string to int

string numberString = "123";
int intValue = int.Parse(numberString); // Parse string to int

```

### Expression and Statements

An **expression** is a combination of variables, constants, operators, and functions that evaluates to a value. 

Expressions are used to compute values and perform operations.

- Arithmetic (``a + b``)
- Relational (``a > b``)
- Logical (``a && b``)
- Conditional (``a > b ? a : b``)

#### Statements

```cs
/**---Declaration---**/
int age; // Variable declaration
const double PI = 3.14; // Constant declaration

/**---Assignment ---**/
int age = 25; // Variable assignment
age = 30; // Reassignment

/**---Expression  ---**/
int result = 5 + 10; // Expression statement
Console.WriteLine(result); // Outputs 15
```

### Variables

Variables are storage locations with a name and type that hold data. They can be used to store, modify, and retrieve data.

**Scope** - The scope of a variable determines where it can be accessed. Variables declared within a block are only accessible within that block.

**Variable Lifetime** - The lifetime of a variable is the duration for which it exists in memory. 

Local variables are created and destroyed with the method they are declared in, while global variables persist for the lifetime of the program.