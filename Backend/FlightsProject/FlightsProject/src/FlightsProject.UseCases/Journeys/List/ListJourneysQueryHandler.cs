using FlightsProject.Core.Entities;
using FlightsProject.Core.Interfaces;
using FlightsProject.UseCases.Graphs;

namespace FlightsProject.UseCases.Journeys.List;
internal sealed class ListJourneysQueryHandler : IRequestHandler<FilterJourneyCommand, ErrorOr<IReadOnlyList<JourneyDTO>>>
{
  private readonly IFlightRepository _flightRepository;

  public ListJourneysQueryHandler(IFlightRepository flightRepository)
  {
    _flightRepository = flightRepository ?? throw new ArgumentNullException(nameof(flightRepository));
  }
  public async Task<ErrorOr<IReadOnlyList<JourneyDTO>>> Handle(FilterJourneyCommand command, CancellationToken cancellationToken)
  {
    try
    {

      string source = command.Origin;
      string destination = command.Destination;

      IReadOnlyList<Flight> flights = await _flightRepository.GetFlightsAsync();

      List<Flight> flightList = flights.ToList();
      var journeyFlights = Graph.FindAllPaths(flightList, source, destination);

      List<Journey> journeys= new List<Journey>();
      foreach (var flightsAux in journeyFlights)
      {
        Journey journey = new Journey { Origin = source, Destination = destination, Price = 0, Flights = flightsAux};
        journeys.Add(journey);
      }

      return journeys.Select(journey => new JourneyDTO(
              journey.Origin,
              journey.Destination,
              journey.TotalPrice,
              journey.Flights
          )).ToList();
    }
    catch(Exception ex)
    {
      
      return Error.Failure("List Journey Failure ",ex.Message);

    }
    
  }
}
