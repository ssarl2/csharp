class Parameters
{
    static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    public static void SwapExample()
    {
        int i = 1, j = 2;
        Console.WriteLine($"{i} {j}");
        Console.WriteLine("swap references");
        Swap(ref i, ref j);
        Console.WriteLine($"{i} {j}");
    }

    static void Divide(int x, int y, out int quotient, out int remainder)
    {
        quotient = x / y;
        remainder = x % y;
    }

    public static void OutUsage()
    {
        int quo;
        Divide(10, 3, out quo, out int rem);
        Console.WriteLine($"{quo} {rem}");
    }

    // Examples of A parameter array
    public static void MyWrite(string fmt, params object[] args)
    {
        Console.Write(fmt, args);
    }
    public static void MyWriteLine(string fmt, params object[] args)
    {
        Console.WriteLine(fmt, args);
    }
}