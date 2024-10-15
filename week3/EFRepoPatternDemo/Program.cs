
using EFDemo.Data;
using EFDemo.Models;
namespace EFDemo;

class Program
{
    static void Main(string[] args)
    {
        //Create a new repository
        IUserRepo userRepo = new UserRepo(); // this is our interface to perform CRUD operations
        IDonations donationRepo = new DonationRepo();

        //userRepo.addUser(new User{ Name = "Vlada", Age = 105});
        //userRepo.addUser(new User{ Name = "Kate", Age = 13});

        //donationRepo.AddDonation(new Donation{ UserId = 1, Amount = 1000});
        //donationRepo.AddDonation(new Donation{ UserId = 1, Amount = 200});


        List<User> userList = userRepo.getAllUsers();
        foreach (User user in userList)
        {
            user.PrintUserData();
            user.PrintDonations();
        }
    }
}
