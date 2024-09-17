using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Patika_Middleware_Practice_Repo.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Add custom middleware
// app.Use(async (context, next) =>
// {
//     Console.WriteLine("Middleware 1 started.");
//     await next.Invoke();
//     Console.WriteLine("Middleware 1 ended.");
// });

// app.Use(async (context, next) =>
// {
//     Console.WriteLine("Middleware 2 started.");
//     await next.Invoke();
//     Console.WriteLine("Middleware 2 ended.");
// });

// app.Use(async (context, next) =>
// {
//     Console.WriteLine("Middleware 3 started.");
//     await next.Invoke();
//     Console.WriteLine("Middleware 3 ended.");
// });

app.UseHello();

app.Use(async (context, next) =>
{
    Console.WriteLine("Use middleware started.");
    await next.Invoke();
});

// app.map
app.Map("/example", internalApp =>
    internalApp.Run(async context =>
    {
        Console.WriteLine("/example middleware started.");
        await context.Response.WriteAsync("/example middleware started.");
    })
);

// app.MapWhen();
app.MapWhen(x => x.Request.Method == "GET", internalApp =>
{
    internalApp.Run(async context => 
    {
        Console.WriteLine("MapWhen middleware triggered.");
        await context.Response.WriteAsync("MapWhen middleware started.");
    });
});



// Add the weather forecast endpoint
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

// Start the app
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
