namespace EFRepoPatternDemo.Models;
public class User{ 
    public int Id { get; set; } // Primary Key
    public string Name { get; set; }
    public int Age { get; set; }

    //Mark One-to-many relationship with Donation
    public List<Donation> Donations { get; set; } = new List<Donation>(); // Collection of Donations related to this User.


    public void PrintUserData(){
        Console.WriteLine($"User Name: {Name}, Age: {Age}");
    }

    public void PrintDonations(){
        Console.WriteLine($"User Name: {Name} Donation:");
        foreach(var donation in Donations){
            Console.WriteLine($"Amount: {donation.Amount}");
        }

    }
}