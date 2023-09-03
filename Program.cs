class Example
{
    public static void Main()
    {
        Entity.SetNextSerialNo(1000);
        Entity e1 = new();
        Entity e2 = new();
        Console.WriteLine(e1.GetSerialNo());
        Console.WriteLine(e2.GetSerialNo());
        Console.WriteLine(Entity.GetNExtSerialNo());
    }
}