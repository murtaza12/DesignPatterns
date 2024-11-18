namespace Builder;

public class Meal
{
    public MainCourse MainCourse { get; set; }
    public SideDish SideDish { get; set; }
    public Drink Drink { get; set; }

    public decimal GetTotalPrice()
    {
        return (MainCourse?.Price ?? 0) + (SideDish?.Price ?? 0) + (Drink?.Price ?? 0);
    }
}
