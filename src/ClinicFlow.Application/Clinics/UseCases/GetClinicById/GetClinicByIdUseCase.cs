using ClinicFlow.Application._Common.Exceptions;
using ClinicFlow.Application.Clinics.Common;
using ClinicFlow.Domain.Entities;
using ClinicFlow.Domain.Repositories;
using MediatR;

namespace ClinicFlow.Application.Clinics.UseCases.GetClinicById;

public class GetClinicByIdUseCase
    : IRequestHandler<GetClinicByIdInput, ClinicModelOutput>
{
    private readonly IClinicRepository _clinicRepository;

    public GetClinicByIdUseCase(IClinicRepository clinicRepository)
    {
        _clinicRepository = clinicRepository;
    }

    public async Task<ClinicModelOutput> Handle(
        GetClinicByIdInput request,
        CancellationToken cancellationToken)
    {
        if (await _clinicRepository.GetClinicByIdAsync(
            request.Id, 
            cancellationToken)! is not Clinic clinic)
        {
            throw new NotFoundException($"Clinic {request.Id} not found.");
        }

        return new ClinicModelOutput();
    }
}
