using FlightsProject.Core.Primitives;

namespace FlightsProject.Core.Entities;

public sealed class Journey: AggregateRoot
{
  public Guid Id { get; private set; }
  public string? Origin { get; set; }
  public string? Destination { get; set; }
  public double? Price { get; set; }

  public List<Flight>? Flights { get; set; }

  public Journey(string origin, string destination, double price, List<Flight> flights)
  {
    Origin = origin;
    Destination = destination;
    Price = price;
    Flights = flights;
  }

  public Journey() { }
}



