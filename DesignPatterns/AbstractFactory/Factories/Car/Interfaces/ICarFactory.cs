using AbstractFactory.Products;

namespace AbstractFactory.Factories;

public interface ICarFactory
{
    IEngine CreateEngine();
    ITire CreateTire();
}
