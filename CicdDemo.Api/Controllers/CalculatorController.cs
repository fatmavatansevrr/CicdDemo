using CicdDemo.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CicdDemo.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class CalculatorController : ControllerBase
{
    private readonly ICalculatorService _calculatorService;

    public CalculatorController(ICalculatorService calculatorService)
    {
        _calculatorService = calculatorService;
    }

    [HttpGet("add")]
    public ActionResult<int> Add([FromQuery] int firstNumber, [FromQuery] int secondNumber)
    {
        return Ok(_calculatorService.Add(firstNumber, secondNumber));
    }

    [HttpGet("subtract")]
    public ActionResult<int> Subtract([FromQuery] int firstNumber, [FromQuery] int secondNumber)
    {
        //test
        return Ok(_calculatorService.Subtract(firstNumber, secondNumber));
    }
}
