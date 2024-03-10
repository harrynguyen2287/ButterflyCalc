namespace ButterflyCalc.Core.Services;

public interface ICalculationService {
  double Add(double a, double b);
  double Substract(double a, double b);
  double Multiply(double a, double b);
  double Divide(double a, double b);
}