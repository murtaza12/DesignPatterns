namespace Prototype.ShallowCopy;

public class Address
{
    public string? Street { get; set; }
    public string? City { get; set; }
}

public class Employee : ICloneable
{
    public string? Name { get; set; }
    public Address? Address { get; set; }

    // Shallow copy using MemberwiseClone
    public object Clone()
    {
        return this.MemberwiseClone();
    }
}
