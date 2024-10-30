using Microsoft.EntityFrameworkCore;
using BudgetTracker.Data;
using BudgetTracker.Models;
using BudgetTracker.API;
using BudgetTracker.API.Service;
using BudgetTracker.API.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(co => {
    co.AddPolicy("name" , pb =>{
        pb.WithOrigins("*")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configure our DBContext and Repos here

// retrieve connection string from user secrets
string connectionString = builder.Configuration["ConnectionStrings:Expenses"]; 
//set up DbContext
builder.Services.AddDbContext<BudgetContext>(options => options.UseSqlServer(connectionString));

// Set up dependencies lifecycles
builder.Services.AddScoped<IExpenseRepo, ExpenseRepo>();
builder.Services.AddScoped<IExpenseService, ExpenseService>();

builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddControllers(); // Configure services to use controllers
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => "Hello!");
app.UseCors("name");
app.UseHttpsRedirection();

//To make .NET see your controllers
app.UseRouting();


// Make your app to use it (Map it)
app.MapControllers();
// app.UseEndpoints(endpoints =>
//     {
//         endpoints.MapControllers(); // Maps attribute-routed controllers
//     });

app.Run();
