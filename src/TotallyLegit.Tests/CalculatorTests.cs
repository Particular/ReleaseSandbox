namespace TotallyLegit.Tests;

using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void GetTotal_returns_zero_initially()
    {
        var calculator = new Calculator();

        Assert.That(calculator.GetTotal(), Is.EqualTo(0));
    }

    [Test]
    public void Add_increases_total_by_amount()
    {
        var calculator = new Calculator();

        var result = calculator.Add(5);

        Assert.That(result, Is.EqualTo(5));
        Assert.That(calculator.GetTotal(), Is.EqualTo(5));
    }

    [Test]
    public void Subtract_decreases_total_by_amount()
    {
        var calculator = new Calculator();
        calculator.Add(10);

        var result = calculator.Subtract(4);

        Assert.That(result, Is.EqualTo(6));
        Assert.That(calculator.GetTotal(), Is.EqualTo(6));
    }

    [Test]
    public void Multiply_multiplies_total_by_amount()
    {
        var calculator = new Calculator();
        calculator.Add(3);

        var result = calculator.Multiply(4);

        Assert.That(result, Is.EqualTo(12));
        Assert.That(calculator.GetTotal(), Is.EqualTo(12));
    }

    [Test]
    public void Operations_can_be_chained()
    {
        var calculator = new Calculator();

        calculator.Add(10);
        calculator.Subtract(2);
        calculator.Multiply(3);

        Assert.That(calculator.GetTotal(), Is.EqualTo(24));
    }
}
