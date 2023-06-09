
[TestFixture]
public class CircleTests
{
    [TestCase(0,0)]
    [TestCase(3.2, 32.169908772759484)]
    [TestCase(39.0, 4778.362426110075)]
    [TestCase(23478324, 1731745452388171.5)]
    public void AreaCalculation_IsCorrect(double radius, double expected)
    {
        var epsilon = 1e-5;
        Assert.That(expected, Is.EqualTo(new Circle(radius).Area).Within(epsilon));
    }

    [TestCase(-10)]
    [TestCase(-12391012)]
    public void Constructor_WhenRadiusNonPositive_ShouldThrowException(double radius)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
    }
}
