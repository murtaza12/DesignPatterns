namespace Singleton;

public sealed class LazySingleton
{
    private static Lazy<LazySingleton> _instance = new(() => new LazySingleton());

    // Private constructor to restrict instantiation
    private LazySingleton() { }

    public static LazySingleton Instance => _instance.Value;

    public string GetMessage() => "Lazy Singleton Instance";
}
