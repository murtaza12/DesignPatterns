using Prototype.DeepCopy;

namespace Prototype.Test.DeepCopy;

public class DeepCopyPrototypeTests
{
    [Fact]
    public void Should_CopyObject_DifferentReferenceForNestedObject()
    {
        var original = new Employee
        {
            Name = "John Doe",
            Address = new Address { Street = "123 Main St", City = "Metropolis" }
        };

        var copy = (Employee)original.Clone();

        // Assert deep copy
        Assert.NotSame(original, copy);
        Assert.NotSame(original.Address, copy.Address); // Nested object references are different
    }
}
