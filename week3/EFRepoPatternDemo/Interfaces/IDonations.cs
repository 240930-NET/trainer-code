using EFRepoPatternDemo.Models;

namespace EFRepoPatternDemo;

public interface IDonations{

    public string AddDonation(Donation donation);
    public List<Donation> GetAllDonations();
    public string RemoveDonation(int id);
}