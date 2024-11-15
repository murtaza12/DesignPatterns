using AbstractFactory.Products;

namespace AbstractFactory.Factories;

public class GasolineCarFactory : ICarFactory
{
    public IEngine CreateEngine() => new GasolineEngine();

    public ITire CreateTire() => new GasolineTire();
}
