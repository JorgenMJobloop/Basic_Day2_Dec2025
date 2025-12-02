using System.Net.Http.Headers;

namespace Basic_Day2;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Hello, welcome to my calculator.");
        Console.WriteLine("Select number 1: [0..INT_MAX]");
        var numberOne = Console.ReadLine();
        Console.WriteLine("Select number 2: [0..INT_MAX]");
        var numberTwo = Console.ReadLine();
        Console.WriteLine("Select an operation:\n'+', '-', '*', '/', '^', 'sin(a)', 'cos(a)', 'tan(a)'");
        var oper = Console.ReadLine(); // this does not need to parsed.

        // convert the user input (currently strings) to doubles
        var a = double.TryParse(numberOne, out var num1);
        var b = double.TryParse(numberTwo, out var num2);
        // Do pattern matching, by switching the operator

        switch (oper)
        {
            case "+":
                calculator.PrintSum(oper, num1, num2);
                break;
            case "-":
                calculator.PrintSum(oper, num1, num2);
                break;
            case "*":
                calculator.PrintSum(oper, num1, num2);
                break;
            case "/":
                calculator.PrintSum(oper, num1, num2);
                break;
            default:
                Console.WriteLine("Something went wrong, exiting program..");
                return;
        }
    }
}
