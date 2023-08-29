class Example
{
    public static void Main()
    {
        var pair = new Pair<int, string>(1, "two");
        int i = pair.First;     //TFirst int
        string s = pair.Second; //TSecond string

        Console.WriteLine($"(First int {i} Second string {s})");
    }
}