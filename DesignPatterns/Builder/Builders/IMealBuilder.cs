namespace Builder;

public interface IMealBuilder
{
    void AddMainCourse();
    void AddSideDish();
    void AddDrink();
    Meal GetMeal();
}