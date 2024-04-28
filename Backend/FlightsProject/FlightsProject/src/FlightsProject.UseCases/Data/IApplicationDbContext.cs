using FlightsProject.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlightsProject.UseCases.Data;
public interface IApplicationDbContext
{
  DbSet<Journey> Journeys { get; set; }

  Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
