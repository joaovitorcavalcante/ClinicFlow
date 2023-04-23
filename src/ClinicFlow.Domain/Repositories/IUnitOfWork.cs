namespace ClinicFlow.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CommitAsync(CancellationToken cancellationToken);
    }
}
