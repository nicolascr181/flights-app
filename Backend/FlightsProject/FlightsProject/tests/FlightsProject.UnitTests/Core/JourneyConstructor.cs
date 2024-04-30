using FlightsProject.Core.Entities;
using Xunit;

namespace FlightsProject.UnitTests.Core;
public class JourneyConstructor
{
  private readonly string _testTotalPrice = "$5,511.60";
  private readonly string _testTotalPriceEUR = "3.000,00 €";
  private Journey? _testJourney;
  private Journey CreateJourneyUSD()
  {
    List<Flight> flights = [
      new Flight("MZL", "PEI", 2001.2, new Transport("AV","4212")),
      new Flight("MZL", "PEI", 1500.2, new Transport("AV","4212")),
      new Flight("MZL", "PEI", 2010.2, new Transport("AV","4212"))
      ];

    return new Journey("MZL","BOG",0,flights, "en-US");
  }

  private Journey CreateJourneyEUR()
  {
    List<Flight> flights = [
      new Flight("MZL", "PEI", 1000, new Transport("AV","4212")),
      new Flight("MZL", "PEI", 1000, new Transport("AV","4212")),
      new Flight("MZL", "PEI", 1000, new Transport("AV","4212"))
      ];

    return new Journey("MZL", "BOG", 0, flights, "es-ES");
  }

  [Fact]
  public void ComputeTotalPriceUSD()
  {
    _testJourney = CreateJourneyUSD();

    Assert.Equal(_testTotalPrice, _testJourney.TotalPrice);
  }

  [Fact]
  public void ComputeTotalPriceEUR()
  {
    _testJourney = CreateJourneyEUR();

    Assert.Equal(_testTotalPriceEUR, _testJourney.TotalPrice);
  }
}
