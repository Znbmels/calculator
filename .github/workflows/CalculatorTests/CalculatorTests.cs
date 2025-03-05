using Xunit;

public class CalculatorTests
{
    [Fact]
    public void Addition_WorksCorrectly()
    {
        var calc = new Calculator();
        double result = calc.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Division_ByZero_ThrowsException()
    {
        var calc = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));
    }
}
