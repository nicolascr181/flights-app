
using FlightsProject.Infrastructure;
using FlightsProject.UseCases;
using FlightsProject.Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();

if (builder.Environment.IsDevelopment())
{

}

var app = builder.Build();

if (app.Environment.IsDevelopment())
{ 
  app.UseSwagger();
  app.UseSwaggerUI();
  app.ApplyMigrations();
}

app.MapControllers();

app.UseHttpsRedirection();

app.Run();


// Make the implicit Program.cs class public, so integration tests can reference the correct assembly for host building
public partial class Program
{
}
