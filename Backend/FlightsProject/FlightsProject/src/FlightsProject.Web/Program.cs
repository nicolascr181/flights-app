
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


if (builder.Environment.IsDevelopment())
{

}

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseDeveloperExceptionPage();
}

app.MapControllers();

app.UseHttpsRedirection();

app.Run();


// Make the implicit Program.cs class public, so integration tests can reference the correct assembly for host building
public partial class Program
{
}
