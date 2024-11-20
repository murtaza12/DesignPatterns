namespace Prototype.DeepCopy;

public class Address
{
    public string? Street { get; set; }
    public string? City { get; set; }

    // Deep Copy for Address
    public Address DeepCopy()
    {
        return new Address
        {
            Street = this.Street,
            City = this.City
        };
    }
}

public class Employee : ICloneable
{
    public string? Name { get; set; }
    public Address Address { get; set; }

    // Deep Copy using custom method
    public object Clone()
    {
        return new Employee
        {
            Name = this.Name,
            Address = Address.DeepCopy()
        };
    }
}