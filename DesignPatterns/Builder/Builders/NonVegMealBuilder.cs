namespace Builder;

public class NonVegMealBuilder : IMealBuilder
{
    private readonly Meal _meal = new Meal();

    public void AddMainCourse()
    {
        _meal.MainCourse = new MainCourse { Name = "Grilled Chicken", Price = 12.99m };
    }

    public void AddSideDish()
    {
        _meal.SideDish = new SideDish { Name = "Fries", Price = 3.99m };
    }

    public void AddDrink()
    {
        _meal.Drink = new Drink { Name = "Coke", Price = 1.99m };
    }

    public Meal GetMeal()
    {
        return _meal;
    }
}
