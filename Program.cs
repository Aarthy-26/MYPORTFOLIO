using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyPortfolio.Services; // Add this line to reference PortfolioService

var builder = WebApplication.CreateBuilder(args);

// Register PortfolioService as a Singleton
builder.Services.AddSingleton<PortfolioService>();

builder.Services.AddRazorPages();
var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();

app.Run();
