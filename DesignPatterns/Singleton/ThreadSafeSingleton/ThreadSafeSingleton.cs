namespace Singleton;

public sealed class ThreadSafeSingleton
{
    private static ThreadSafeSingleton? _instance;
    private static readonly object _lock = new();

    // Private constructor to restrict instantiation
    private ThreadSafeSingleton() { }

    public static ThreadSafeSingleton Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new ThreadSafeSingleton();
                }
            }
            return _instance;
        }
    }

    public string GetMessage() => "Thread-Safe Singleton Instance";
}
