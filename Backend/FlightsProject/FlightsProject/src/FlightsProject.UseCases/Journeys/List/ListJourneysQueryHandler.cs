using FlightsProject.Core.Entities;
using FlightsProject.Core.Interfaces;

namespace FlightsProject.UseCases.Journeys.List;
internal sealed class ListJourneysQueryHandler : IRequestHandler<ListJourneysQuery, ErrorOr<IReadOnlyList<JourneyDTO>>>
{
  private readonly IJourneyRepository _journeyRepository;

  public ListJourneysQueryHandler(IJourneyRepository journeyRepository)
  {
    _journeyRepository = journeyRepository ?? throw new ArgumentNullException(nameof(journeyRepository));
  }
  public async Task<ErrorOr<IReadOnlyList<JourneyDTO>>> Handle(ListJourneysQuery command, CancellationToken cancellationToken)
  {
    try
    {
      IReadOnlyList<Journey> journeys = await _journeyRepository.GetJourneysAsync();

      return journeys.Select(journey => new JourneyDTO(
              journey.Origin,
              journey.Destination,
              journey.Price,
              journey.Flights
          )).ToList();
    }
    catch(Exception ex)
    {
      
      return Error.Failure("List Journey Failure ",ex.Message);

    }
    
  }
}
