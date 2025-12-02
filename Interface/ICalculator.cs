public interface ICalculator
{
    /// <summary>
    /// A method that returns the sum of two numbers (a + b)
    /// </summary>
    /// <param name="a">the value of the number a</param>
    /// <param name="b">the value of the number b</param>
    /// <returns>the sum of a + b</returns>
    double AddNumbers(double a, double b);
    /// <summary>
    /// A method that returns the sum of a number (a) minus another number (b) (a - b)
    /// </summary>
    /// <param name="a">the value of the number a</param>
    /// <param name="b">the value of the number b</param>
    /// <returns>the sum of a - b</returns>
    double SubtractNumbers(double a, double b);
    /// <summary>
    /// A method that returns the sum of a number (a) times another number (b) (a * b)
    /// </summary>
    /// <param name="a">the value of the number a</param>
    /// <param name="b">the value of the number b</param>
    /// <returns>the sum of a * b</returns>
    double MultiplyNumbers(double a, double b);
    /// <summary>
    /// A method that returns the sum of a number (a) divided by a number (b) if b is not less than or zero
    /// </summary>
    /// <param name="a">the value of number a</param>
    /// <param name="b">the value of number b, cannot be less than or zero</param>
    /// <returns>the sum of a / b</returns>
    /// <exception cref="DivideByZeroException"/>
    double DivideNumbers(double a, double b);
}