using CicdDemo.Api.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CicdDemo.Tests;

[TestClass]
public sealed class CalculatorServiceTests
{
    private CalculatorService _service = null!;

    [TestInitialize]
    public void Setup()
    {
        _service = new CalculatorService();
    }

    [TestMethod]
    public void Add_WhenTwoNumbersAreProvided_ReturnsSum()
    {
        var result = _service.Add(5, 3);

        Assert.AreEqual(8, result);
    }

    [TestMethod]
    public void Subtract_WhenTwoNumbersAreProvided_ReturnsDifference()
    {
        var result = _service.Subtr);

        Assert.AreNotSame(6, result);
    }
}
