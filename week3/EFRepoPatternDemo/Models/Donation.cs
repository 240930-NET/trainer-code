namespace EFRepoPatternDemo.Models;
public class Donation{
    public int DonationId { get; set; } // Primary key
    public double Amount { get; set; }

    // Foreign Key for User table
    public int UserId { get; set; } 
    //Navigation Property
    public User User { get; set; } // One to Many relationship with User table

    public void PrintDonation(){
        Console.WriteLine($"Amount: {Amount}");
    }
}