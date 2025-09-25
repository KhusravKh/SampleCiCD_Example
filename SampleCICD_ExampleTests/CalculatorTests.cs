using SampleCICD_Example;

namespace SampleCICD_ExampleTests;

public class CalculatorTests
{
    private readonly Calculator _calculator = new();

    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        var result = _calculator.Add(3, 5);
        Assert.Equal(8, result);
    }

    [Fact]
    public void Multiply_ReturnsCorrectProduct()
    {
        var result = _calculator.Multiply(4, 6);
        Assert.Equal(24, result);
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(3, false)]
    [InlineData(10, true)]
    [InlineData(15, false)]
    public void IsEven_ReturnsCorrectResult(int number, bool expected)
    {
        var result = _calculator.IsEven(number);
        Assert.Equal(expected, result);
    }
}