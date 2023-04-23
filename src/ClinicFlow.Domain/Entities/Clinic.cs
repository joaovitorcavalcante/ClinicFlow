using ClinicFlow.Domain.Abstractions;
using ClinicFlow.Domain.ValueObjects;

namespace ClinicFlow.Domain.Entities;

public class Clinic : EntityBase
{
    public string Name { get; private set; }
    public Phone Phone { get; private set; }
    public Address Address { get; private set; }
    public bool IsActive { get; private set; }


    public Clinic(
        string name, 
        Phone phone, 
        Address address)
    {
        Name = name;
        Phone = phone;
        Address = address;
        IsActive = true;
    }
}
