using EFRepoPatternDemo.Models;
using Microsoft.EntityFrameworkCore;


namespace EFRepoPatternDemo.Data;

public class UserRepo : IUserRepo{    
    
    private readonly MyContext _context; // this holds reference to the context

    public UserRepo(MyContext context){
        _context = context;
    }

    public List<User> getAllUsers(){
            return _context.Users.Include(u => u.Donations).ToList();        
    }
  
    public User getUserById(int id){
        User searchedUser = _context.Users.Find(id);

        if( searchedUser != null){
            return searchedUser;
        }
        else{
            Console.WriteLine("User not found");
            return null;
        }
    }

    public User userByName(string name){
         User searchedUser = _context.Users.Where(user => user.Name == name).FirstOrDefault();

        if( searchedUser != null){
            return searchedUser;
        }
        else{
            Console.WriteLine("User not found");
            return null;
        }        
    }
    public string addUser(User user){
        if(user.Name != ""){
            _context.Users.Add(user);
            _context.SaveChanges(); // to save you data, otherwise it will not persist

            return "User added successfully";
        }
        else{
            return "Invalid name";
        }
    }
    public string updateUser(User user){
        User existingUser = _context.Users.Find(user.Id);
        if(existingUser != null){
            //Change to new data
            existingUser.Name = user.Name;
            existingUser.Age = user.Age;

            //Save
            _context.SaveChanges();
            return "User was successfully updated";
        }
        else{
            return "User not found";
        }
    }
    public string deleteUser(int id){
        //Find the user in the database
        User searchedUser = _context.Users.Find(id);
        if( searchedUser != null){

            _context.Users.Remove(searchedUser);
            _context.SaveChanges();
            return "User removed successfully";
        }
        else{
            return "User not found";
        }
    }


}