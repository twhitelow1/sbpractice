using Microsoft.EntityFrameworkCore;
using snow_buddies.infrastructure.data;
using snow_buddies.infrastructure.Repositories;
using snow_buddies.application.IServices;
using snow_buddies.application.Services;
using snow_buddies.application.IRepositories;
using Npgsql;



var builder = WebApplication.CreateBuilder(args);

var connectionStringFromConfig = builder.Configuration.GetConnectionString("SBConnectionString");
string? dbPassword = builder.Configuration["DbPassword"];

var npgsqlConStrBuilder = new NpgsqlConnectionStringBuilder(connectionStringFromConfig)
{
    Password = dbPassword
};

var fullConnectionString = npgsqlConStrBuilder.ToString();

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddDbContext<SnowBuddiesDbContext>(options => options.UseNpgsql(fullConnectionString));

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
