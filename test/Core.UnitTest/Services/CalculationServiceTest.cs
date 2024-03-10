using ButterflyCalc.Core.Common;
using ButterflyCalc.Core.Services;

namespace ButterflyCalc.Core.UnitTest.Services;

public class CalculationServiceTest
{
  private readonly ICalculationService _calculationService;

  public CalculationServiceTest()
  {
    _calculationService = new CalculationService();
  }

  [Fact]
  public void Add_ReturnExpectedResult()
  {
    // Given
    double a = 5;
    double b = 3;


    // When
    double result = _calculationService.Add(a, b);

    // Then
    Assert.Equal(8, result);
  }

  [Fact]
  public void Subtract_ReturnExpectedResult()
  {
    // Given
    double a = 5;
    double b = 3;

    // When
    double result = _calculationService.Subtract(a, b);

    // Then
    Assert.Equal(2, result);
  }

  [Fact]
  public void Multiply_ReturnExpectedResult()
  {
    // Given
    double a = 5;
    double b = 3;

    // When
    double result = _calculationService.Multiply(a, b);

    // Then
    Assert.Equal(15, result);
  }

  [Fact]
  public void Divide_ReturnExpectedResult()
  {
    // Given
    double a = 6;
    double b = 3;

    // When
    double result = _calculationService.Divide(a, b);

    // Then
    Assert.Equal(2, result);
  }

  [Fact]
  public void Divide_ShouldReturnError_WhenDividingByZero()
  {
    // Given
    double a = 6;
    double b = 0;

    // When
    Action act = () => _calculationService.Divide(a, b);

    // Then
    var result = Assert.Throws<Exception>(act);
    Assert.Equal(ErrorMessage.CannotDivideByZero, result.Message);
  }
}