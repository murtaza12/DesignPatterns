namespace Singleton.Test;

public class EagerSingletonTests
{
    [Fact]
    public void Should_ReturnSameInstance()
    {
        var instance1 = EagerSingleton.Instance;
        var instance2 = EagerSingleton.Instance;

        Assert.Same(instance1, instance2);
        Assert.Equal("Eager Singleton Instance", instance1.GetMessage());
    }
}
