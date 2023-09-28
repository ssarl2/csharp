class Example
{
    public static void Main()
    {
        MyList<int> a = new();
        a.Add(1);
        a.Add(2);
        MyList<int> b = new();
        b.Add(1);
        b.Add(2);
        Console.WriteLine(a == b);  // Outputs "True"
        b.Add(3);
        Console.WriteLine(a == b);  // Outputs "False"
    }
}