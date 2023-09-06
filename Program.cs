class Example
{
    public static void Main()
    {
        /*
         * The constructor has static modifier in the class
         * So, it's called a static constructor
         */
        MyList<string> list1 = new();

        /*
         * The constructor is declared normally without any modifiers
         * So, it's called an instance constructor
         */
        MyList<string> list2 = new(10);
    }
}