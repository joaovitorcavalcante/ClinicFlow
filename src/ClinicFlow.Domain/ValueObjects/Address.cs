namespace ClinicFlow.Domain.ValueObjects;

public class Address
{
    public string Street { get; private set; }
    public string Number { get; private set; }

    public Address(
        string street, 
        string number)
    {
        Street = street;
        Number = number;
    }
}
