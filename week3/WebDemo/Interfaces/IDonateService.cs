using WebDemo.Data;

namespace WebDemo.Interfaces;


public interface IDonateService{

    public List<Donation> DisplayDonations();
    public string AddDonation(Donation donation);
    public string DeleteDonation(Donation donation);

}