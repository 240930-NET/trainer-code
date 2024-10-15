using Microsoft.EntityFrameworkCore;
using EFDemo.Models;
using EFDemo;

namespace EFDemo.Data;

public class DonationRepo : IDonations {


    public string AddDonation(Donation donation){
        using(var context = new MyContext()){

            context.Donations.Add(donation);
            context.SaveChanges();
            return "Donation added successfully";
        }
    }

    public List<Donation> GetAllDonations(){
        using(var context = new MyContext()){

            return context.Donations.ToList();
        }
    }

    public string RemoveDonation(int id){
        
        using(var context = new MyContext()){
            var donation = context.Donations.Find(id);
            if(donation!=null){
                context.Donations.Remove(donation);
                context.SaveChanges();
                return "Donation removed successfully";
            }
            return "Donation not found";
        }
    }
}