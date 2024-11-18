namespace Builder;

public class MealDirector
{
    public Meal PrepareMeal(IMealBuilder builder)
    {
        builder.AddMainCourse();
        builder.AddSideDish();
        builder.AddDrink();
        return builder.GetMeal();
    }
}
