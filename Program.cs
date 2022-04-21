using BankingApp.Adapter;
using BankingApp.Decorator;
using BankingApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => c.EnableAnnotations());
builder.Services.AddSingleton<DataService>();
builder.Services.AddMemoryCache();
builder.Services.AddTransient<CachedStockService>();
builder.Services.AddTransient<IStockService, StockService>();
builder.Services.AddTransient<StockService>();
builder.Services.AddTransient<INewStockCrawler, NewStockCrawler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
