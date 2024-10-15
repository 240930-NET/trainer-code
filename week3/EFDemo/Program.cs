using Microsoft.EntityFrameworkCore; // this one allows us to work with DBContext and EF Core

namespace EFDemo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting");

        //Create a new User to enter to DB
        User Kate = new User{Name = "Kate", Age = 34};
        User Lena = new User{Name = "Lena", Age = 14};
        User Alex = new User{Name = "Alex", Age = 54};


        //Try to add it to the DB
        //AddUser(Kate);
        //AddUser(Lena);

        //AddUser(Alex);
        //User searchedUser = GetUserById(1); 
        //User searchedUserByName = GetUserByName("Lena"); 

       // Console.WriteLine("We found user with id 1: " + searchedUser.Name); // should return us user Kate
       // searchedUserByName.PrintUserData(); // should return us user Lena

  

        //edit user, instead of Kate we should have Rick
        EditUser(new User {Id = 1, Name = "Rick", Age = 34});
        RemoveUser(3);

        List<User> allUsers = GetAllUsers();

        foreach(User user in allUsers){
            user.PrintUserData();
        }


    }

     // CRUD Operations

        //Get all Users
        public static List<User> GetAllUsers(){
            
            using(var userContext = new UserContext()){
                return userContext.Users.ToList();
            }
        }

        //Get userById
        public static User GetUserById(int id){
            using(var userContext = new UserContext()){

                User searchedUser = userContext.Users.Find(id);

                if( searchedUser != null){
                    return searchedUser;
                }
                else{
                    Console.WriteLine("User not found");
                    return null;
                }

            }
        }

        //Get user by name
        public static User GetUserByName(string name){
            using (var userContext = new UserContext()){
                User searchedUser = userContext.Users.Where(user => user.Name == name).FirstOrDefault();

                if( searchedUser != null){
                    return searchedUser;
                }
                else{
                    Console.WriteLine("User not found");
                    return null;
                }
            
            }
        }

        // Add a new user
        public static string AddUser(User newUser){
            using(var userContext = new UserContext()){

                //After all validation User is ok
                if(newUser.Name != ""){
                    userContext.Users.Add(newUser);
                    userContext.SaveChanges(); // to save you data, otherwise it will not persist

                    return "User added successfully";
                }
                else{
                    return "Invalid name";
                }
                
            }
        
        }

        // Remove a user
        public static string RemoveUser(int id){

            using(var userContext = new UserContext()){

                //Find the user in the database
                User searchedUser = userContext.Users.Find(id);
                if( searchedUser != null){

                    userContext.Users.Remove(searchedUser);
                    userContext.SaveChanges();
                    return "User removed successfully";
                }
                else{
                    return "User not found";
                }
            }

        }

        //Edit user
        public static string EditUser(User newUserData){
            using(var userContext = new UserContext()){
                //Get user by Id
                User existingUser = userContext.Users.Find(newUserData.Id);
                if(existingUser != null){
                    //Change to new data
                    existingUser.Name = newUserData.Name;
                    existingUser.Age = newUserData.Age;

                    //Save
                    userContext.SaveChanges();
                    return "User was successfully updated";
                }
                else{
                    return "User not found";
                }
                
            }
        }
    
    

}

//Create a model-table User that will represent our table
public class User{ // Use will be a name of our future table
    public int Id { get; set; } // this will automatically become Primary Key
    public string Name { get; set; }
    public int Age { get; set; }


    public void PrintUserData(){
        Console.WriteLine($"User Name: {Name}, Age: {Age}");
    }
}

// To use DBContext we have to install 3 packages to our project sqllite, design and sqlserver
// We create a new class that will inherit properties from DBContext
public class UserContext : DbContext {

    public DbSet<User> Users { get; set; } // define DBSet of user

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {   
        string ConnectionString = File.ReadAllText("./connectionString.txt");
        optionsBuilder.UseSqlServer(ConnectionString); 
    }
}