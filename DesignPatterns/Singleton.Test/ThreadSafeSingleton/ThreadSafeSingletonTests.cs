namespace Singleton.Test;

public class ThreadSafeSingletonTests
{
    [Fact]
    public void Should_ReturnSameInstance()
    {
        var instance1 = ThreadSafeSingleton.Instance;
        var instance2 = ThreadSafeSingleton.Instance;

        Assert.Same(instance1, instance2);
        Assert.Equal("Thread-Safe Singleton Instance", instance1.GetMessage());
    }
}