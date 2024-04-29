
using System;
using FlightsProject.Infrastructure;
using FlightsProject.Infrastructure.Data;
using FlightsProject.Infrastructure.Persistence;
using FlightsProject.UseCases;
using FlightsProject.Web.Extensions;
using Serilog;
using Serilog.Extensions.Logging;

var logger = Log.Logger = new LoggerConfiguration()
  .Enrich.FromLogContext()
  .WriteTo.Console()
  .CreateLogger();

logger.Information("Starting web host");

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((_, config) => config.ReadFrom.Configuration(builder.Configuration));
var microsoftLogger = new SerilogLoggerFactory(logger)
    .CreateLogger<Program>();

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

app.UseExceptionHandler("/error");

app.MapControllers();

app.UseHttpsRedirection();

SeedDatabase(app);

app.Run();

static void SeedDatabase(WebApplication app)
{
  using var scope = app.Services.CreateScope();
  var services = scope.ServiceProvider;

  try
  {
    var context = services.GetRequiredService<ApplicationDbContext>();
    //          context.Database.Migrate();
    context.Database.EnsureCreated();
    SeedData.Initialize(services);
  }
  catch (Exception ex)
  {
    var logger = services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An error occurred seeding the DB. {exceptionMessage}", ex.Message);
  }
}


// Make the implicit Program.cs class public, so integration tests can reference the correct assembly for host building
public partial class Program
{
}
