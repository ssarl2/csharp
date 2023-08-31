class Example
{
    private static bool IsNull<T>(T? v)
    {
        if (v == null)
            return true;
        return false;
    }

    public static void Main()
    {
        int? optionalInt = default;
        string? optionalText = default;

        if (IsNull(optionalInt))
        {
            Console.WriteLine($"(optionalInt is null)");
        }
        if (IsNull(optionalText))
        {
            Console.WriteLine($"(optionalText is null)");
        }

        optionalInt = 5;
        optionalText = "Hello World.";

        if (!IsNull(optionalText))
        {
            Console.WriteLine($"(optionalInt : {optionalInt})");
        }
        if (!IsNull(optionalText))
        {
            Console.WriteLine($"(optionalText : {optionalText})");
        }
    }
}