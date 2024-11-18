namespace Builder;

public class VegMealBuilder : IMealBuilder
{
    private readonly Meal _meal = new Meal();

    public void AddMainCourse()
    {
        _meal.MainCourse = new MainCourse { Name = "Vegetable Curry", Price = 8.99m };
    }

    public void AddSideDish()
    {
        _meal.SideDish = new SideDish { Name = "Salad", Price = 4.99m };
    }

    public void AddDrink()
    {
        _meal.Drink = new Drink { Name = "Lemonade", Price = 2.99m };
    }

    public Meal GetMeal()
    {
        return _meal;
    }
}