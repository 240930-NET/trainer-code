
using WebDemo.Data;

namespace WebDemo.Interfaces;

//Provide all CRUD operations you need to
public interface IUserRepo{

    public List<User> getAllUsers();
    public User getUserById(int id);
    public User userByName(string name);
    public string addUser(User user);
    public string updateUser(User user);
    public string deleteUser(int id);

}