using ClinicFlow.Domain.Entities;

namespace ClinicFlow.Domain.Repositories;

public interface IClinicRepository
{
    Task<Clinic>? FindByIdAsync(Guid id, CancellationToken cancellationToken);
}
