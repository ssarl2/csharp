class Example
{
    public static void Main()
    {
        var turnip = SomeRootVegetable.Turnip;

        var spring = Seasons.Spring;
        var startingOnEquinox = Seasons.Spring | Seasons.Autumn;
        var theYear = Seasons.All;

        Console.WriteLine($"(turnip : {turnip})");
        Console.WriteLine($"(spring : {spring})");
        Console.WriteLine($"(startingOnEquinox : {startingOnEquinox})");
        Console.WriteLine($"(theYear : {theYear})");
    }
}