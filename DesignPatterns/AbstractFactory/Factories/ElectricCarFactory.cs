using AbstractFactory.Products;

namespace AbstractFactory.Factories;

public class ElectricCarFactory : ICarFactory
{
    public IEngine CreateEngine() => new ElectricEngine();

    public ITire CreateTire() => new ElectricTire();
}