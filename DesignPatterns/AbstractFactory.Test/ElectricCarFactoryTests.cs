using AbstractFactory.Factories;
using AbstractFactory.Products;

namespace AbstractFactory.Test;

public class ElectricCarFactoryTests
{
    [Fact]
    public void ElectricCarFactory_Should_CreateElectricEngine_And_ElectricTire()
    {
        // Arrange
        ICarFactory factory = new ElectricCarFactory();

        // Act
        var engine = factory.CreateEngine();
        var tire = factory.CreateTire();

        // Assert
        Assert.IsType<ElectricEngine>(engine);
        Assert.IsType<ElectricTire>(tire);
        Assert.Equal("Electric Engine", engine.GetEngineType());
        Assert.Equal("Electric Tire", tire.GetTireType());
    }
}

