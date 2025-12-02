public class Calculator : ICalculator
{
    public double AddNumbers(double a, double b)
    {
        return a + b;
    }

    public double DivideNumbers(double a, double b)
    {
        if (b <= 0)
        {
            throw new DivideByZeroException("Divisor cannot be less than or equal to zero!");
        }
        return a / b;
    }

    public double MultiplyNumbers(double a, double b)
    {
        return a * b;
    }

    public double SubtractNumbers(double a, double b)
    {
        return a - b;
    }

    public double CosA(double a)
    {
        return Math.Cos(a);
    }

    public double SinA(double a)
    {
        return Math.Sin(a);
    }

    public double TanA(double a)
    {
        return Math.Tan(a);
    }

    public void PrintSum(string op, double a, double b)
    {
        double sum;
        switch (op)
        {
            case "+":
                sum = AddNumbers(a, b);
                Console.WriteLine($"{a} + {b} = {sum}");
                break;
            case "-":
                sum = SubtractNumbers(a, b);
                Console.WriteLine($"{a} - {b} = {sum}");
                break;
            case "*":
                sum = MultiplyNumbers(a, b);
                Console.WriteLine($"{a} * {b} = {sum}");
                break;
            case "/":
                sum = DivideNumbers(a, b);
                Console.WriteLine($"{a} / {b} = {sum}");
                break;
            case "sin(a)":
                sum = SinA(a);
                Console.WriteLine($"sin({a}) = {sum}");
                break;
            case "cos(a)":
                sum = CosA(a);
                Console.WriteLine($"cos({a}) = {sum}");
                break;
            case "tan(a)":
                sum = TanA(a);
                Console.WriteLine($"tan({a}) = {sum}");
                break;
        }
    }
}