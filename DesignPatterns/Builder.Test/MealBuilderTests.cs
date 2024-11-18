namespace Builder.Test;

public class MealBuilderTests
{
    [Fact]
    public void VegMealBuilder_ShouldBuildVegMealCorrectly()
    {
        // Arrange
        var vegBuilder = new VegMealBuilder();
        var director = new MealDirector();

        // Act
        var meal = director.PrepareMeal(vegBuilder);

        // Assert
        Assert.Equal("Vegetable Curry", meal.MainCourse.Name);
        Assert.Equal("Salad", meal.SideDish.Name);
        Assert.Equal("Lemonade", meal.Drink.Name);
        Assert.Equal(16.97m, meal.GetTotalPrice());
    }

    [Fact]
    public void NonVegMealBuilder_ShouldBuildNonVegMealCorrectly()
    {
        // Arrange
        var nonVegBuilder = new NonVegMealBuilder();
        var director = new MealDirector();

        // Act
        var meal = director.PrepareMeal(nonVegBuilder);

        // Assert
        Assert.Equal("Grilled Chicken", meal.MainCourse.Name);
        Assert.Equal("Fries", meal.SideDish.Name);
        Assert.Equal("Coke", meal.Drink.Name);
        Assert.Equal(18.97m, meal.GetTotalPrice());
    }

}