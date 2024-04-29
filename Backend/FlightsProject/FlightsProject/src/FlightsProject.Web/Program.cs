
using FlightsProject.Infrastructure;
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

app.Run();


// Make the implicit Program.cs class public, so integration tests can reference the correct assembly for host building
public partial class Program
{
}
