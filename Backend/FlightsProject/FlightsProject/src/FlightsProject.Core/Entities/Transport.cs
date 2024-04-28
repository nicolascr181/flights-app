namespace FlightsProject.Core.Entities;
public sealed class Transport
{
  public string FlightCarrier { get; set; }

  public string FlightNumber { get; set; }

  public Transport(string flightCarrier, string flightNumber)
  {
    FlightCarrier = flightCarrier;
    FlightNumber = flightNumber;
  }
}
