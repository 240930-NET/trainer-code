using WebDemo.Data;
using WebDemo.Interfaces;

// Services helps you with additional processing logic before you interact with you repo and data
public class DonateService : IDonateService{

    private readonly IDonateRepo _repo; // dependency injection you have configure lifecycle of it

    public DonateService(IDonateRepo repo){
        _repo =  repo;

    }

    public List<Donation> DisplayDonations(){

        try{
            var donationList  = _repo.GetAllDonations();
            return donationList.Count > 0 ? donationList : null;
        }
        catch(Exception e){

            Console.WriteLine(e.Message);
            return null;
        }
    }
    public string AddDonation(Donation donation){

        try{
            if(donation.Amount > 0){
                return _repo.AddDonation(donation);
            }
            else{
                return "Invalid donation amount";
            }
        }

        catch(Exception e){
            Console.WriteLine(e.Message);
            return null;
        }
    }
    public string DeleteDonation(Donation donation){

        try{
            // Find donation entry from all donation where id is the same as the donation argument ID
            var selectedDonation = _repo.GetAllDonations().FirstOrDefault(d => d.DonationId == donation.DonationId);
            if(selectedDonation != null){
                return  _repo.RemoveDonation(selectedDonation);
            }
            else{
                return "Donation does not exist";
            }
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
            return null;
        }
    }
}