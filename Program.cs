class Example
{
    public static void Main()
    {
        Point a = new(10, 20);
        Point b = new Point();
        b.X = 30.0;
        b.Y = 50.0;

        Console.WriteLine($"(Point a.X {a.X} Point a.Y {a.Y})");
        Console.WriteLine($"(Point b.X {b.X} Point b.Y {b.Y})");

        /* This somehow does not work.
         * Looks like the document from microsoft, Point3D can refers to
         * Point. So, seemed to be able to call b.Z. But, Not working
         * https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types
         */
    }
}