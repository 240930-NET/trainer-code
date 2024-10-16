using Microsoft.EntityFrameworkCore; 

var builder = WebApplication.CreateBuilder(args);
//Bad practice!!! Use appsetting.json instead
var connectionString = "Server=localhost;Database=PetAppDb;User Id=sa;Password=NotPassword;Trusted_Connection=True;TrustServerCertificate=true;";
// Set up DBContext 
builder.Services.AddDbContext<PetContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();
//string myUser = "Vlada";

//app.MapGet("/", () => "Hello World!");
//app.MapGet("/user", () => $"Hello {myUser}");

// use Minimal API to get pets

//Get used to retrieve data
app.MapGet("/pets", async (PetContext context) => {

    var pets = await context.Pets.ToListAsync(); //retrieve pets from our database asynchronously

    //If we have pets then we want to return status Ok and list of pets, 
    //else we want to return status 404 and string no pets
    return pets.Any() ? Results.Ok(pets) : Results.NotFound("No pets found");
});

//Post used to add a new entry
app.MapPost("/AddPet", async (PetContext context, Pet newPet) => {

    context.Pets.Add(newPet); //add new pet to our database
    await context.SaveChangesAsync(); //save changes to the database
    
    return Results.Created("Created", newPet); //return status 201 and the added pet
});

// Find pet by Id
app.MapGet("/pet/{id}", async (int id, PetContext context) => {
    var pet = await context.Pets.FindAsync(id); //find pet by id from our database
    return pet!= null? Results.Ok(pet) : Results.NotFound("Pet not found"); //if pet found return it, else return 404
});

// Find pet by Name
app.MapGet("/findPetByName/{name}", async (string name, PetContext context)=> {
    var pet = await context.Pets.FirstOrDefaultAsync(p => p.Name == name);
    return pet != null ? Results.Ok(pet) : Results.NotFound("Pet not found");
});

// Update pet
app.MapPut("/UpdatePet", async (PetContext context, Pet updatedPet) => {
    var existingPet = await context.Pets.FindAsync(updatedPet.PetId);
    if (existingPet == null) {
        return Results.NotFound("Pet not found");
    }
    existingPet.Name = updatedPet.Name;
    existingPet.Type = updatedPet.Type;
    existingPet.Age = updatedPet.Age;
    
    await context.SaveChangesAsync();
    
    return Results.Ok(existingPet);
});



// Delete pet
/*
app.MapDelete("/DeletePet", async (PetContext context, Pet deletePet) => {

    var existingPet = await context.Pets.FindAsync(deletePet.PetId);

    if (existingPet == null) 
    {
        return Results.Ok(); //return 200 when nothing to delete
    } 
    context.Pets.Remove(existingPet); //delete pet from the database
    await context.SaveChangesAsync(); //save changes to the database
    
    return Results.Ok("Deleted"); //return status
});
*/

app.MapDelete("/DeletePet/{id}", async (int id, PetContext context) => {

    var existingPet = await context.Pets.FindAsync(id);

    if (existingPet == null) 
    {
        return Results.Ok(); //return 200 when nothing to delete
    } 
    context.Pets.Remove(existingPet); //delete pet from the database
    await context.SaveChangesAsync(); //save changes to the database
    
    return Results.Ok("Deleted"); //return status
});

app.Run();

//Muhahahahahah - Kung
