namespace Singleton.Test;

public class LazySingletonTests
{
    [Fact]
    public void Should_ReturnSameInstance()
    {
        var instance1 = LazySingleton.Instance;
        var instance2 = LazySingleton.Instance;

        Assert.Same(instance1, instance2);
        Assert.Equal("Lazy Singleton Instance", instance1.GetMessage());
    }
}