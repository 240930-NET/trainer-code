using BudgetTracker.Models;

namespace BudgetTracker.Data;
public interface IUserRepo{

    public Task<List<User>> GetAllUsers(); // return List of Users asynchronously
    public Task<User> GetUserById(int id); 
    public Task<User> AddUser(User user);
    public Task<User> UpdateUser(User user); 
    public Task deleteUserById(User user); // return void
}