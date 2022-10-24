using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CeuEscore.Data;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CeuEscoreContext>(options =>
    options.UseMySql("Server=localhost;userid=admin;password=admin;database=ceuEscoreDB",Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
