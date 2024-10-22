using BudgetTracker.Models;
using BudgetTracker.Data;


namespace BudgetTracker.API.Service;
public interface IUserService{

    //Get 
    public Task<List<User>> GetAllUsers();

    //Get by Id
    public Task<User> GetUserById(int id);

    //Add
    public Task<User> AddNewUser(User user);

    //Update
    public Task<User> UpdateUser(User user);

    //Delete
    public Task<User> DeleteUser(int id);
}
