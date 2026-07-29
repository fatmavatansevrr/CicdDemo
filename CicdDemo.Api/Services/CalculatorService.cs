namespace CicdDemo.Api.Services;

public sealed class CalculatorService : ICalculatorService
{
    public int Add(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

    public int Subtract(int firstNumber, int secondNumber)
    {
        return firstNumber - secondNumber;
    }
}
