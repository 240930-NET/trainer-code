using ClassDemo.MyUser; // include your file User to this namespace

namespace ClassDemo;


class Program
{
    static void Main(string[] args)
    {
        //User personeOne = new User("Thomas", "Doe", 34);

        //personeOne.PrintUserName();

        /*
        Console.WriteLine("Thomas is " + personeOne.getAge());
        personeOne.setAge(67);
        Console.WriteLine("Thomas now is " + personeOne.getAge());
        personeOne.setAge(-1);
        Console.WriteLine("Thomas now is " + personeOne.getAge());
        */

        //Object Initializers
        // You just need one default constructor (no params)
        // And it is make your code cleaner and easier to read, because you don't have to create multiple constructors

        //User personTwo = new User {FirstName = "Shrek", LastName = "the Ogr"};
        User personTwo = new User {LastName = "the Ogr"};
        personTwo.PrintUserName();
        personTwo.changeAge(90);
        Console.WriteLine(personTwo.FirstName + " is " + personTwo.getAge() + " years old");

    }
}
