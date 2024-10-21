using Microsoft.EntityFrameworkCore;
using WebDemo.Data;
using WebDemo.Interfaces;


var builder = WebApplication.CreateBuilder(args);

//Configure DbContext
//var connectionString = builder.Configuration["ConnectionString"]; 
// reference to the connection string in user secrets

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


builder.Services.AddDbContext<EfdemoContext>(options =>
    options.UseSqlServer(connectionString));


//Here we will configure Services and repositories
builder.Services.AddScoped<IDonateRepo, DonationRepo>();
builder.Services.AddScoped<IDonateService, DonateService>();

var app = builder.Build();


// Get all Donations 
//app.MapGet("/", () => "Hellor World");

app.MapGet("/donations", (IDonateService service) => {

    var donations = service.DisplayDonations();

    if(donations != null){
        return Results.Ok(donations);
    }
    else{
        return Results.NotFound();
    }
});

app.Run();
