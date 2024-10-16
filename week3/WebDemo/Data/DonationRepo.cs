using WebDemo.Interfaces;
namespace WebDemo.Data;

public class DonationRepo : IDonateRepo {
    
    private readonly EfdemoContext _context; // this holds reference to the context

    public DonationRepo(EfdemoContext context){
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

    public string RemoveDonation(Donation donation){
         _context.Donations.Remove(donation);
         _context.SaveChanges();
          return "Donation removed successfully";

    }
}