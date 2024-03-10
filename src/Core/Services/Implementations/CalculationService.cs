namespace ButterflyCalc.Core.Services;

public class CalculationService : ICalculationService
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Substract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        return a / b;
    }
}