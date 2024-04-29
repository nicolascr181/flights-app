using FlightsProject.UseCases.Journeys.List;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlightsProject.Web.Controllers;
[Route("api/[controller]")]
[ApiController]
public class JourneyController : APIController
{
  private readonly ISender _mediator;

  public JourneyController(ISender mediator)
  {
    _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
  }
  

  /// <summary>
  /// List all journeys without filters
  /// </summary>
  /// <returns></returns>
  [HttpGet]
  public async Task<IActionResult> ListJourneys()
  {
    var journeysResult = await _mediator.Send(new ListJourneysQuery());

    return journeysResult.Match(
        journey => Ok(journey),
        errors => Problem(errors)
    );
  }
}
