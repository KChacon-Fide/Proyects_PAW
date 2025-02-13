using PAW.Business;
using PAW.Data.Models;
using Microsoft.EntityFrameworkCore;
using PAW.Data.Repository;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepositoryBase<Category>, RepositoryBase<Category>>();
builder.Services.AddScoped<IRepositoryBase<Supplier>, RepositoryBase<Supplier>>();
builder.Services.AddScoped<CategoryManager>();
builder.Services.AddScoped<SupplierManager>();

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
