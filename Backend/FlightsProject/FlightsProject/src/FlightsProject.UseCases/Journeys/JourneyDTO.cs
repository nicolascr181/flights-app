using FlightsProject.Core.Entities;

namespace FlightsProject.UseCases.Journeys;
public record JourneyDTO(string origin, string destination, double price, Flight[] flights){}
