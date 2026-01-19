using System;

public class DivideByZeroException : Exception
{
    public DivideByZeroException(string message) : base(message) { }
}

public class InvalidNumberException : Exception
{
    public InvalidNumberException(string message) : base(message) { }
}

public class UnknownOperatorException : Exception
{
    public UnknownOperatorException(string message) : base(message) { }
}

public class InvalidExpressionException : Exception
{
    public InvalidExpressionException(string message) : base(message) { }
}

public class ArithmeticExpression
{
    public static string Evaluate(string expression)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(expression))
                throw new InvalidExpressionException("Error:InvalidExpression");

            string[] parts = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 3)
                throw new InvalidExpressionException("Error:InvalidExpression");

            if (!int.TryParse(parts[0], out int a) ||
                !int.TryParse(parts[2], out int b))
                throw new InvalidNumberException("Error:InvalidNumber");

            string op = parts[1];



            if (op == "/" && b == 0)
                return "Error:DivideByZero";

            return op switch
            {
                "+" => (a + b).ToString(),
                "-" => (a - b).ToString(),
                "*" => (a * b).ToString(),
                "/" => (a / b).ToString(),
                _ => throw new UnknownOperatorException("Error:UnknownOperator")

            };
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    public static void Run()
    {
        // Read full expression (example: "3 + 5")
        string? expression = Console.ReadLine();

        string result = ArithmeticExpression.Evaluate(expression!);

        Console.WriteLine(result);
    }


}

