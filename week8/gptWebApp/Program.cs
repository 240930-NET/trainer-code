using Microsoft.SemanticKernel;

var config  = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
var gptAPIKEY = config["apiKey"];
var bingAPIKEY = config["bingAPI"];

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddKernel();
builder.Services.AddOpenAIChatCompletion("gpt-3.5-turbo", gptAPIKEY!);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/", async (Kernel kernel) =>
{
        var temp = Random.Shared.Next(45, 55);
        return new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(Random.Shared.Next(5))),
            temp,
            await kernel.InvokePromptAsync<string>($"Give me a 5 word discription of what it feels like in {temp} degrees C.")
        );
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
