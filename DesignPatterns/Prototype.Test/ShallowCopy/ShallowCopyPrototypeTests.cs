using Prototype.ShallowCopy;

namespace Prototype.Test.ShallowCopy;

public class ShallowCopyPrototypeTests
{
    [Fact]
    public void Should_CopyObject_SameReferenceForNestedObject()
    {
        var original = new Employee
        {
            Name = "John Doe",
            Address = new Address { Street = "123 Main St", City = "Metropolis" }
        };

        var copy = (Employee)original.Clone();

        // Assert shallow copy
        Assert.NotSame(original, copy);
        Assert.Same(original.Address, copy.Address); // Nested object references are the same
    }
}
