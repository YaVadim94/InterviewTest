using AwesomeSquareCalculator;

namespace AwesomeCalculatorsTests;

public class UnitTest1
{
    [Fact(DisplayName = "Проверка расчёта площади треугольника")]
    public void Should_Calculate_Triangle_Square()
    {
        var triangle = new Triangle(3, 4, 5);

        const int expected = 6;
        
        var calculator = new SquareCalculator();

        var square = calculator.Calculate(triangle);
        
        Assert.Equal(expected, square);
    }
    
    
    [Fact(DisplayName = "Проверка расчёта площади окружности")]
    public void Should_Calculate_Circle_Square()
    {
        var triangle = new Circle(1);

        const double expected = Math.PI;
        
        var calculator = new SquareCalculator();

        var square = calculator.Calculate(triangle);
        
        Assert.Equal(expected, square);
    }
    
    [Fact(DisplayName = "Проверка валидации окружности")]
    public void Should_Correctly_Validate_Circle()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
    
    [Fact(DisplayName = "Проверка валидации треугольника")]
    public void Should_Correctly_Validate_Triangle()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 3, 5));
    }
    
    [Fact(DisplayName = "Проверка вычисления правильности треугольника")]
    public void Should_Identify_Right_Triangle()
    {
        var triangle = new Triangle(3, 4, 5);
        
        Assert.True(triangle.IsRightTriangle);
    }
}