using BudgetTracker.Models;
using BudgetTracker.Data;


namespace BudgetTracker.API.Service;
public interface IUserService{

    public Task<User> GetUserById(int id);
    public Task<List<User>> GetAddUsers();
    public Task<User> AddUser(User user);
    public Task<User> UpdateUser(User user);
    public Task DeleteUser(int id);
}