namespace Factory.Test;

public class AnimalFactoryTests
{
    [Fact]
    public void CreateAnimal_ShouldReturnDog_WhenDogTypeIsProvided()
    {
        // Arrange
        var animalType = "Dog";

        // Act
        var animal = AnimalFactory.CreateAnimal(animalType);

        // Assert
        Assert.NotNull(animal);
        Assert.IsType<Dog>(animal);
        Assert.Equal("Woof!", animal.Speak());
    }

    [Fact]
    public void CreateAnimal_ShouldReturnCat_WhenCatTypeIsProvided()
    {
        // Arrange
        var animalType = "Cat";

        // Act
        var animal = AnimalFactory.CreateAnimal(animalType);

        // Assert
        Assert.NotNull(animal);
        Assert.IsType<Cat>(animal);
        Assert.Equal("Meow!", animal.Speak());
    }

    [Fact]
    public void CreateAnimal_ShouldThrowArgumentException_WhenInvalidAnimalTypeIsProvided()
    {
        // Arrange
        var invalidAnimalType = "Bird";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => AnimalFactory.CreateAnimal(invalidAnimalType));
    }
}