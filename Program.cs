class Example
{
    public static void Main()
    {
        // First example from the microsoft document
        Expression e = new Operation(
    new VariableReference("x"),
    '*',
    new Operation(
        new VariableReference("y"),
        '+',
        new Constant(2)
    )
);
        Dictionary<string, object> vars = new();
        vars["x"] = 3;
        vars["y"] = 5;
        Console.WriteLine(e.Evaluate(vars));
        vars["x"] = 1.5;
        vars["y"] = 9;
        Console.WriteLine(e.Evaluate(vars));

        // Second example
        Dictionary<string, object> variables = new Dictionary<string, object>();
        variables["x"] = 5.0;
        variables["y"] = 3.0;

        Expression left = new Constant(5.0);
        Expression right = new VariableReference("x");
        Expression operation = new Operation(left, '+', right);

        double result = operation.Evaluate(variables);
        Console.WriteLine($"{result}");
    }
}