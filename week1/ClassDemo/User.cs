namespace ClassDemo.MyUser;


//Class is a blueprint that is used to create our objects. It has properties and methods
class User{

    /*
    Properties vs Fields

    Fields :

    - usually private
    - directly represent data in a class
    - access it through methods or properties


    Properties: 

    - Combination of fields and methods
    - Proprties are public 
    - Control mechanism to work with fields
    */

    public string? FirstName { get; set; } // this is a property 

    public string? LastName {get; set; } // this is a property too

    private int age; // this is a field


    // Constructor - we use it to initialize/create an object.
    //public User(){} // Default, no params

    /*
    public User(string fName, string lName, int age){

        this.FirstName = fName;
        this.LastName = lName;
        this.age = age;
    }*/

    /*
    public User(string fName, string lName){
        this.FirstName = fName;
        this.LastName = lName;
    }*/

    //One statement constructor
    /*
    public User(string fName, string lName, int age) => (this.FirstName, this.LastName, this.age) = (fName, lName, age)
    */

    public void PrintUserName(){
        //string interpolation
        Console.WriteLine($" I' am {age} years old, and my name is {FirstName} {LastName}");
    }

    //Getter for age
    public int getAge(){
        return this.age;
    }

    //Setter for age
    public void setAge(int n){
        if(n < 0){
            Console.WriteLine("It is not a valid number");
        }
        else{
            this.age = n;
        }
    }

    public void changeAge(int n){

        this.age += n;
        Console.WriteLine($"Now our {FirstName} is {age}");
    }
}