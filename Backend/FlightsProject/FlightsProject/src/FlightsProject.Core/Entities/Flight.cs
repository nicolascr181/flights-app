using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightsProject.Core.Entities;
public class Flight
{
  
  public string Origin { get; set; }

  
  public string Destination { get; set; }

  public double Price { get; set; }

  public Transport Transport { get; set; }

  public Flight(string origin, string destination, double price, Transport transport)
  {
    Origin = origin;
    Destination = destination;
    Price = price;
    Transport = transport;
  }
}
