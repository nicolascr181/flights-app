namespace FlightsProject.UseCases.Journeys.List;
public record ListJourneysQuery() : IRequest<ErrorOr<IReadOnlyList<JourneyDTO>>>;

