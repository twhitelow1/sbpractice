using Microsoft.EntityFrameworkCore;
using snow_buddies.infrastructure.data;
using snow_buddies.infrastructure.Repositories;
using snow_buddies.application.IServices;
using snow_buddies.application.Services;
using snow_buddies.application.IRepositories;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddDbContext<SnowBuddiesDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("SBConnectionString")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();
