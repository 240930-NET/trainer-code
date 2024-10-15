using EFRepoPatternDemo.Models;

namespace EFRepoPatternDemo.Data;

public class DonationRepo : IDonations {
    
    private readonly MyContext _context; // this holds reference to the context

    public DonationRepo(MyContext context){
        _context = context;
    }

    public string AddDonation(Donation donation){
        _context.Donations.Add(donation);
        _context.SaveChanges();
        return "Donation added successfully";
    }

    public List<Donation> GetAllDonations(){
        return _context.Donations.ToList();
    }

    public string RemoveDonation(int id){
        var donation = _context.Donations.Find(id);
        if(donation!=null){
            _context.Donations.Remove(donation);
            _context.SaveChanges();
            return "Donation removed successfully";
        }
        return "Donation not found";
    }
}