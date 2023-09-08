class Example
{
    public static void Main()
    {
        MyList<string> names = new();
        names.Capacity = 100;   // Invokes set accessor
        int i = names.Count;    // Invokes get accessor
        int j = names.Capacity; // Invokes get accessor
        Console.WriteLine($"i={i}, j={j}");
    }
}