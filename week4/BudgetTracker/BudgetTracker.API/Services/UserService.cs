using BudgetTracker.Models;
using BudgetTracker.Data;


namespace BudgetTracker.API.Service;

public class UserService : IUserService{

    private readonly IUserRepo _userRepo;

    public UserService(IUserRepo userRepo){
        _userRepo = userRepo;
    }

    public async Task<User> GetUserById(int id){
        User searchedUser =  await _userRepo.GetUserById(id);
        if( searchedUser == null){
            throw new Exception($"No user found with id {id}");
        }
        else{
            return searchedUser;
        }
    }
    public async Task<List<User>> GetAddUsers(){
        List<User> allUsers = await _userRepo.GetAllUsers();
        if(allUsers.Count == 0){
            throw new Exception("No users found");
        }
        return allUsers;
    }
    public Task<User> AddUser(User user){

        if(user.FirstName == null){
            throw new Exception("First Name is required");
        }
        else{
            return _userRepo.AddUser(user);
        }
 
    }
    public async Task<User> UpdateUser(User user){
        if(await _userRepo.GetUserById(user.UserId) == null || user.FirstName == null){
            throw new Exception($"Invalid input!");
        }
        else{
            return await _userRepo.UpdateUser(user);
        }
    }
    public async Task DeleteUser(int id){
        User searchedUser = await _userRepo.GetUserById(id);
        if(searchedUser == null){
            throw new Exception($"Invalid input!");
        }
        else{
         await _userRepo.UpdateUser(searchedUser);
        }
    }
}