using System;
using MediatR;

namespace FlightsProject.Core.Entities;

public class Journey
{
  
  public string Origin { get; set; }
  public string Destination { get; set; }
  public double Price { get; set; }
  public Flight[] Flights { get; set; }

  public Journey(string origin, string destination, double price, Flight[] flights)
  {
    Origin = origin;
    Destination = destination;
    Price = price;
    Flights = flights;
  }
}



