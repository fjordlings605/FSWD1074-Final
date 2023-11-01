using burble_api.Migrations;
using burble_api.Models;
using burble_api.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<BurbDatabaseSettings>(
    builder.Configuration.GetSection("BurbDatabaseSettings"));
builder.Services.AddScoped<IBurbRepository, BurbRepository>();
// builder.Services.AddSqlite<BurbleDbContext>("Data Source=burble_api.db");

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
