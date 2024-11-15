using AbstractFactory.Factories;
using AbstractFactory.Products;

namespace AbstractFactory.Test;

public class GasolineCarFactoryTests
{
    [Fact]
    public void GasolineCarFactory_Should_CreateGasolineEngine_And_GasolineTire()
    {
        // Arrange
        ICarFactory factory = new GasolineCarFactory();

        // Act
        var engine = factory.CreateEngine();
        var tire = factory.CreateTire();

        // Assert
        Assert.IsType<GasolineEngine>(engine);
        Assert.IsType<GasolineTire>(tire);
        Assert.Equal("Gasoline Engine", engine.GetEngineType());
        Assert.Equal("Gasoline Tire", tire.GetTireType());
    }
}