
using WebDemo.Data;

namespace WebDemo.Interfaces;
public interface IDonateRepo{

    public string AddDonation(Donation donation);
    public List<Donation> GetAllDonations();
    public string RemoveDonation(Donation donation);
}