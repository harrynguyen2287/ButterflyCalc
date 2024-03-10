using System.ComponentModel.DataAnnotations;
using ButterflyCalc.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace ButterflyCalc.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculationController : ControllerBase
{
  private readonly ICalculationService _calculationService;
  public CalculationController(ICalculationService calculationService)
  {
    _calculationService = calculationService;
  }

  // GET: api/Calculation/add
  [HttpGet]
  [Route("add")]
  public IActionResult Add(double a, double b)
  {
    var res = _calculationService.Add(a, b);
    return Ok(res);
  }

  // GET: api/Calculation/Subtract
  [HttpGet]
  [Route("Subtract")]
  public IActionResult Subtract(double a, double b)
  {
    var res = _calculationService.Subtract(a, b);
    return Ok(res);
  }

  // GET: api/Calculation/multiply
  [HttpGet]
  [Route("multiply")]
  public IActionResult Multiply(double a, double b)
  {
    var res = _calculationService.Multiply(a, b);
    return Ok(res);
  }

  // GET: api/Calculation/divide
  [HttpGet]
  [Route("divide")]
  public IActionResult Divide(double a, [RegularExpression("(.*[1-9].*)|(.*[.].*[1-9].*)", ErrorMessage = "Cannot divide by zero")] double b)
  {
    var res = _calculationService.Divide(a, b);
    return Ok(res);
  }
}