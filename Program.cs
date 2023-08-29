class Example
{
    public static void Main()
    {
        var factory = new PointFactory(10);
        foreach (var point in factory.CreatePoints())
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }
    }
}