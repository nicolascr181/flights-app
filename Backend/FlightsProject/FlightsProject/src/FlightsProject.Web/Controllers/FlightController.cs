using FlightsProject.UseCases.Flights.List;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FlightsProject.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FlightController : APIController
{
  private readonly ISender _mediator;

  public FlightController(ISender mediator)
  {
    _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
  }

  /// <summary>
  /// List all flights without filters
  /// </summary>
  /// <returns></returns>
  [HttpGet]
  public async Task<IActionResult> ListFlights()
  {
    var flightsResult = await _mediator.Send(new ListFlightsQuery());

    return flightsResult.Match(
        journey => Ok(journey),
        errors => Problem(errors)
    );
  }
}
