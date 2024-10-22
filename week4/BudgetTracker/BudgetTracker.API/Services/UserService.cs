using BudgetTracker.Models;
using BudgetTracker.Data;


namespace BudgetTracker.API;

public class UserService : IUserService {

    private readonly IUserRepo _userRepo;

    //Add constructor here
    public UserService(IUserRepo userRepo){
        _userRepo = userRepo;
    }

    //Get 
    public async Task<List<User>> GetAllUsers(){

        List<User> users =  await _userRepo.GetAllUsers();

        if(users.Count == 0){
            throw new Exception("No users were found");
        }
        else{
            return users;
        }
    }

    //Get by Id
    public async Task<User> GetUserById(int id){
        User searchedUser = await _userRepo.GetUserById(id);
        if(searchedUser == null){
            throw new Exception("User not found");
        }
        else{
            return searchedUser;
        }
    }

    //Add
    public async Task<User> AddNewUser(User user){

        //Little Validation
        if(user.FirstName != ""){
            await _userRepo.AddUser(user);
            return user;
        }
        else{
            throw new Exception("Invalid User. Please provide a first name!");
        }
    
    
    }

    //Update
    public async Task<User> UpdateUser(User user){
        //Check if user already exists
        User searchedUser = await _userRepo.GetUserById(user.UserId); // find if user already exists

        if(searchedUser != null){
            if(user.FirstName != ""){
                await _userRepo.UpdateUser(user);
                return user;
            }
            else{
                throw new Exception("First name is required!");
            }
           
        }
        else{
            throw new Exception("User not found");
        }
    }

    //Delete
    public async Task<User> DeleteUser(int id){

        User searchedUser = await _userRepo.GetUserById(id);

        if(searchedUser != null){
            await _userRepo.deleteUserById(searchedUser);
            return searchedUser;
        }
        else{
            throw new Exception("User not found. Cannot delete it!");
        }
    }
}
