# Collections

We have 2 types of collections in C#

- **Generics** (allow us to store data of a **certain** type)
- **Non-generic collections** (any data type can be stored here)

For non-generic collections, we need to perform
**Boxing** and **Unboxing**

```csharp
//Boxing - from value type to reference type

int Myinteger = 6; // value type
object myConvertedInteger = Myinteger; // Now it is a reference type.


// Unboxing - from reference type to value
object anotherType = 123;
int convertedReference = (int)anotherType;

```

**Data Types in Non-Generics:**

- ArrayList ( resizable, but can store any type);

```csharp

ArrayList mylittleList = new ArrayList();
mylittleList.Add(10);
mylittleList.Add("This is string");

//We have 2 elements of different types int and string in our ArrayList;
```

- HashTable (key/value pairs that can hold any data type)

```csharp
Hashtable MyHastable = new Hashtable();
MyHastable.Add(1, "String");
```

- Queue (FIFO)

```csharp
Queue myqueue = new Queue();
myqueue.Enqueue(1);
```

- Stack (LIFO)

```csharp
Stack stack = new Stack();
stack.Push(1);
stack.Push(1);

var topstackElement = stack.Pop();

```


## Generics

Belongs to ```System.Collections.Generic``` namespace.

```csharp

List<T> // T - means a certain type, you mast declare and only this Type is allowed to be stored in the collection

```

**Generic Data Collections:**
```csharp
- List<T>
- Dictionary<TKey, TValue>

Dictionary<int, string> myDictionary = new Dictionary<int,string>(); // Dictionary<TKey,

- HashSet <T>

- Queue <T>
- Stack<T>
- LinkedList<T>
```

### When to use Different Collections:

- List - when you need a dynamic array with access by index
- Dictionary - when you want to have key/value pair
- HashSet - when you need a collection with unique value
- Queue - when you want Fifo behavio
- Stack - when you want LIFO
- LinkedList - when you frequently want to add or remove items from both ends of the list


### IEnumerable

This interface allows you to iterate over collections. We have IEnumerable (non-generics) and IEnumerable<T> for generic collections.

```csharp

List<string> names = new List<string>{ "Alice", "Vlada", "Bob"};

IEnumerable<string> enumerableNames = names; 

// You can do simple for loop to iterate over the names or use Enumerator instead to more control

IEnumerator<string> enumerator = names.getEnumerator();

while(enumerator.MoveNext()){
    string currentName = enumerator.Current();
    Console.WriteLine(currentName);
}

if(enumerator is IDisposable disposable){
    disposable.Dispose();
}

```