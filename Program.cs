class Example
{
    public static void Main()
    {
        MyList<string> names = new();
        names.Add("Liz");
        names.Add("Martha");
        names.Add("Beth");
        for (int i = 0; i < names.Count; i++)
        {
            string s = names[i];
            names[i] = s.ToUpper();
        }

        Console.WriteLine($"{names.Capacity}");

        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine($"{names[i]}");
        }
        names.Add("Abby");
        names.Add("Boby");
        names.Add("Cebby");
        names.Add("Naby");
        names.Add("Roby");
        Console.WriteLine($"{names.Capacity}");


        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine($"{names[i]}");
        }
    }
}