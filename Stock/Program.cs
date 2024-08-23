using Microsoft.EntityFrameworkCore;
using Stocksy.Stock.Models;
using Stocksy.Stock.Services;

var builder = WebApplication.CreateBuilder(args);

// Configure database
builder.Configuration.GetConnectionString(StockDbContext.connectionString);
builder.Services.AddDbContext<StockDbContext>(options => {
    options.UseSqlite(StockDbContext.connectionString);
});

// Use cross origin support.
const string corsPolicy = "FrontEndApp";
const string frontEndOrigin = "http://localhost:4200";
builder.Services.AddCors(opts => opts.AddPolicy(corsPolicy,
                            policy => 
                            {
                                policy.WithOrigins(frontEndOrigin);
                                policy.AllowAnyHeader();
                                policy.AllowAnyMethod();
                            }));

builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IStockService, StockService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(corsPolicy);

app.MapControllers();

app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();

// record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
// {
//     public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
// }
