using ErrorOr;
using FlightsProject.Core.Entities;
using FlightsProject.Core.Interfaces;
using FlightsProject.UseCases.Journeys.List;
using Moq;
using Xunit;

namespace FlightsProject.UnitTests.UseCases;
public class ListJourneysQueryHandlerTests
{
  private readonly Mock<IFlightRepository> _mockFlightRepository;

  private readonly ListJourneysQueryHandler _queryHandler;

  public ListJourneysQueryHandlerTests()
  {
    _mockFlightRepository = new Mock<IFlightRepository>();
    _queryHandler = new ListJourneysQueryHandler(_mockFlightRepository.Object);
  }

  [Fact]
  public async Task Handle_ReturnsExpectedJourneys()
  {
    // Arrange
    FilterJourneyCommand command = new FilterJourneyCommand
    ("MZL", "PEI", "en-US", "Roundtrip");

    var flights = new List<Flight>
        {
            new Flight { Origin = "MZL", Destination = "BOG" },
            new Flight { Origin = "MZL", Destination = "PEI" },
            new Flight { Origin = "PEI", Destination = "BOG" },
            new Flight { Origin = "PEI", Destination = "MZL" },
            new Flight { Origin = "BOG", Destination = "BCN" },
            new Flight { Origin = "BOG", Destination = "JFK" },
            new Flight { Origin = "BOG", Destination = "MZL" },
            new Flight { Origin = "BOG", Destination = "PEI" },
            new Flight { Origin = "JFK", Destination = "BCN" },
            new Flight { Origin = "JFK", Destination = "MAD" },
            new Flight { Origin = "JFK", Destination = "BOG" },
            new Flight { Origin = "BCN", Destination = "BOG" },
            new Flight { Origin = "MAD", Destination = "BCN" }
        };

    _mockFlightRepository.Setup(repo => repo.GetFlightsAsync())
                        .ReturnsAsync(flights);


    // Act
    var result = await _queryHandler.Handle(command, default);

    //Assert
    Assert.NotNull(result.Value);
    Assert.Equal(2, result.Value.Count); // Roundtrip should have 2 journeys
    Assert.Equal("MZL", result.Value[0].Origin);
    Assert.Equal("PEI", result.Value[0].Destination);
  }
}
