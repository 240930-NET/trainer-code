using EFDemo.Models;
namespace EFDemo;
public interface IDonations{

    public string AddDonation(Donation donation);
    public List<Donation> GetAllDonations();
    public string RemoveDonation(int id);
}