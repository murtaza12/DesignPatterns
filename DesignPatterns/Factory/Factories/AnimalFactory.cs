namespace Factory;

public static class AnimalFactory
{
    public static IAnimal CreateAnimal(string animalType)
    {
        return animalType switch
        {
            "Dog" => new Dog(),
            "Cat" => new Cat(),
            _ => throw new ArgumentException("Invalid animal type")
        };
    }
}
