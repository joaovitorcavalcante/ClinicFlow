using ClinicFlow.Application.Clinics.Common;
using MediatR;

namespace ClinicFlow.Application.Clinics.UseCases.GetClinicById;

public class GetClinicByIdInput : IRequest<ClinicModelOutput>
{
    public Guid Id { get; set; }
}
