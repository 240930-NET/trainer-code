using BudgetTracker.Models;
using BudgetTracker.Data;
using BudgetTracker.API.Models.DTO;
using AutoMapper;


namespace BudgetTracker.API.Service;

public class UserService : IUserService{

    private readonly IUserRepo _userRepo;
    private readonly IMapper _mapper;

    public UserService(IUserRepo userRepo, IMapper mapper){
        _userRepo = userRepo;
        _mapper = mapper;
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
    public async Task<List<User>> GetAllUsers(){
        List<User> allUsers = await _userRepo.GetAllUsers();
        if(allUsers.Count == 0){
            throw new Exception("No users found");
        }
        return allUsers;
    }
    public Task<User> AddUser(NewUserDTO userDTO){

        //Convert from NewUserDTO to User
        // User user = new()
        // {
        //     FirstName = userDTO.FirstName,
        //     LastName = userDTO.LastName
        // };

        var user = _mapper.Map<User>(userDTO);

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
         await _userRepo.deleteUserById(searchedUser);
        }
    }
}