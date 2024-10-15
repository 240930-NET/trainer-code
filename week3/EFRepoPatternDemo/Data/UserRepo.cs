using EFDemo.Models;
using EFDemo;
using Microsoft.EntityFrameworkCore;


namespace EFDemo.Data;

public class UserRepo : IUserRepo{
    
    /*
    static MyContext _context; // this holds reference to the context

    public UserRepo(){

        // Set up configuration 
        var options = new DbContextOptionsBuilder<MyContext>()
        .UseSqlServer("Server=localhost;Database=EFDemo;User Id=sa;Password=NotPassword;Trusted_Connection = true;TrustServerCertificate=true;")
        .Options;

        // Create a new dbContext
        _context = new MyContext(options);
    }*/

    public List<User> getAllUsers(){
        using(var dbContext = new MyContext()){
            return dbContext.Users.Include(u => u.Donations).ToList();
        }
    }
  
    public User getUserById(int id){
         using(var dbContext = new MyContext()){
        User searchedUser = dbContext.Users.Find(id);
                if( searchedUser != null){
                    return searchedUser;
                }
                else{
                    Console.WriteLine("User not found");
                    return null;
                }

        }
    }

    public User userByName(string name){

        using(var dbContext = new MyContext()){
         User searchedUser = dbContext.Users.Where(user => user.Name == name).FirstOrDefault();

                if( searchedUser != null){
                    return searchedUser;
                }
                else{
                    Console.WriteLine("User not found");
                    return null;
                }
        }
    }
    public string addUser(User user){
        using(var dbContext = new MyContext()){

         if(user.Name != ""){
                    dbContext.Users.Add(user);
                    dbContext.SaveChanges(); // to save you data, otherwise it will not persist

                    return "User added successfully";
                }
                else{
                    return "Invalid name";
                }
        }
    }
    public string updateUser(User user){
        using(var dbContext = new MyContext()){

         User existingUser = dbContext.Users.Find(user.Id);
                if(existingUser != null){
                    //Change to new data
                    existingUser.Name = user.Name;
                    existingUser.Age = user.Age;

                    //Save
                    dbContext.SaveChanges();
                    return "User was successfully updated";
                }
                else{
                    return "User not found";
                }

        }
    }
    public string deleteUser(int id){
        //Find the user in the database
            using(var dbContext = new MyContext()){

                User searchedUser = dbContext.Users.Find(id);
                if( searchedUser != null){

                    dbContext.Users.Remove(searchedUser);
                    dbContext.SaveChanges();
                    return "User removed successfully";
                }
                else{
                    return "User not found";
                }
            }
    }


}