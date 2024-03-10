using ButterflyCalc.Core.Common;

namespace ButterflyCalc.Core.Services;

public class CalculationService : ICalculationService
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new Exception(ErrorMessage.CannotDivideByZero);
        }
        return a / b;
    }
}