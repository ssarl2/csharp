class Example
{
    public static void Main()
    {
        Point a = new(10, 20);
        Point b = new Point3D(10, 20, 30);

        Console.WriteLine($"(Point a.X {a.X} Point a.Y {a.Y})");

        /* This somehow does not work.
         * Looks like the document from microsoft, Point3D can refers to
         * Point. So, seemed to be able to call b.Z. But, Not working
         * https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types
         */
        // Console.WriteLine($"(Point3D b.X {b.X} Point3D b.Y {b.Y} Point3D b.Z {b.Z})");
    }
}