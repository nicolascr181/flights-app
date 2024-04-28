using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FlightsProject.Core.Entities;
public class Transport
{
  public string FlightCarrier { get; set; }

  public string FlightNumber { get; set; }

  public Transport(string flightCarrier, string flightNumber)
  {
    FlightCarrier = flightCarrier;
    FlightNumber = flightNumber;
  }
}
