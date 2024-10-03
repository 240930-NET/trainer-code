using System.Text.Json; // we need this to be able to access JsonSerializer

namespace SerializationDemo;

class Program
{
    static void Main(string[] args)
    {
        Person FirstPerson = new Person { Name = "John Doe", Age = 30 };


        // Serialize the object to JSON string and print it.
        string jsonString = JsonSerializer.Serialize(FirstPerson);
        Console.WriteLine(jsonString);

        //Deserialize the JSON string to Person object

        Person deserializedJsonPerson = JsonSerializer.Deserialize<Person>(jsonString);
        Console.WriteLine("Here is the deserialized object: " + deserializedJsonPerson.Name);

    }
}


public class Person {
    public string Name { get; set; }
    public int Age { get; set; }
}