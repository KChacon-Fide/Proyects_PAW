using Microsoft.EntityFrameworkCore;
using PAW.Business;
using PAW.Data.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IProductManager, ProductManager>();
builder.Services.AddDbContext<ProductDbContext>(options =>
    options.UseSqlServer("Server=LAPTOP-HU36SVQB\\MSSQLSERVER08;Database=ProductDB;Trusted_Connection=True;TrustServerCertificate=True;"));

builder.Services.AddScoped<PAW.Data.Repository.IProductRepository, PAW.Data.Repository.ProductRepository>();
builder.Services.AddScoped<PAW.Business.IProductManager, PAW.Business.ProductManager>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
