namespace Singleton;

public sealed class EagerSingleton
{
    private static readonly EagerSingleton _instance = new EagerSingleton();

    // Private constructor to restrict instantiation
    private EagerSingleton() { }

    public static EagerSingleton Instance => _instance;

    public string GetMessage() => "Eager Singleton Instance";
}
