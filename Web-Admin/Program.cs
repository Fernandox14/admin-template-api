using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using Web_Admin.Infra.Repositories;
using Web_Admin_Domain.Domain.Interfaces;
using Web_Admin_Domain.Interface;
using Web_Admin_Infra.Database;
using Web_Admin_Infra.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DatabaseConnection>(options =>
    {
        options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=admin-app;Trusted_Connection=True");
        options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    }
);

#region Repositories
builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<IUserRepository, UserRepository>();
#endregion

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors(options =>
     options.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod());

app.UseAuthorization();

app.MapControllers();

app.Run();


