using ButterflyCalc.Api.Controllers;
using ButterflyCalc.Core.Common;
using ButterflyCalc.Core.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace ButterflyCalc.Api.UnitTest.Controllers;

public class CalculationControllerTest
{
  private readonly Mock<ICalculationService> mockCalculationService;
  private readonly CalculationController controller;
  public CalculationControllerTest()
  {
    mockCalculationService = new Mock<ICalculationService>();
    controller = new CalculationController(mockCalculationService.Object);
  }

  [Fact]
  public void Add_ReturnExpectedResult()
  {
    // Given
    double a = 5;
    double b = 3;
    mockCalculationService.Setup(service => service.Add(a, b)).Returns(8);

    // When
    var result = controller.Add(a, b) as OkObjectResult;

    // Then
    double expected = 8;
    result.Should().NotBeNull();
    result.StatusCode.Should().Be(StatusCodes.Status200OK);
    result.Value.Should().Be(expected);
  }

  [Fact]
  public void Subtract_ReturnExpectedResult()
  {
    // Given
    double a = 5;
    double b = 3;
    mockCalculationService.Setup(service => service.Subtract(a, b)).Returns(2);

    // When
    var result = controller.Subtract(a, b) as OkObjectResult;

    // Then
    double expected = 2;
    result.Should().NotBeNull();
    result.StatusCode.Should().Be(StatusCodes.Status200OK);
    result.Value.Should().Be(expected);
  }

  [Fact]
  public void Multiply_ReturnExpectedResult()
  {
    // Given
    double a = 5;
    double b = 3;
    mockCalculationService.Setup(service => service.Multiply(a, b)).Returns(15);

    // When
    var result = controller.Multiply(a, b) as OkObjectResult;

    // Then
    double expected = 15;
    result.Should().NotBeNull();
    result.StatusCode.Should().Be(StatusCodes.Status200OK);
    result.Value.Should().Be(expected);
  }

  [Fact]
  public void Divide_ReturnExpectedResult()
  {
    // Given
    double a = 6;
    double b = 3;
    mockCalculationService.Setup(service => service.Divide(a, b)).Returns(2);

    // When
    var result = controller.Divide(a, b) as OkObjectResult;

    // Then
    double expected = 2;
    result.Should().NotBeNull();
    result.StatusCode.Should().Be(StatusCodes.Status200OK);
    result.Value.Should().Be(expected);
  }
}