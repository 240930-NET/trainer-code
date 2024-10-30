using BudgetTracker.Models;
using Microsoft.EntityFrameworkCore;
namespace BudgetTracker.Data;

public class UserRepo : IUserRepo{

    private readonly BudgetContext _context;

    public UserRepo(BudgetContext context)
    {
        _context = context;
    }

    public async Task<List<User>> GetAllUsers(){
        return await _context.Users.Include(u => u.Expenses).ToListAsync();
    }
    public async Task<User> GetUserById(int id){
        return await _context.Users.Include(u => u.Expenses).FirstOrDefaultAsync(u => u.UserId == id); // user will be loaded with expenses
    }
    public async Task<User> AddUser(User user){
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
        return user;
    }
    public async Task<User> UpdateUser(User user){
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
        return user;
    }
    public async Task deleteUserById(User user){
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }
}
