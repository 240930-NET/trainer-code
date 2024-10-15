using EFRepoPatternDemo.Data;
using EFRepoPatternDemo.Models;

namespace EFRepoPatternDemo;

class Program
{
    static void Main(string[] args)
    {
        //Create new context
        MyContext DBContext = new();
        //Create a new repository
        UserRepo userRepo = new(DBContext); // this is our interface to perform CRUD operations
        DonationRepo donationRepo = new(DBContext);

        userRepo.addUser(new User{ Name = "Vlada", Age = 105});
        userRepo.addUser(new User{ Name = "Kate", Age = 13});

        donationRepo.AddDonation(new Donation{ UserId = 1, Amount = 1000});
        donationRepo.AddDonation(new Donation{ UserId = 1, Amount = 200});

        List<User> userList = userRepo.getAllUsers();
        foreach (User user in userList)
        {
            user.PrintUserData();
            user.PrintDonations();
        }
    }
}
