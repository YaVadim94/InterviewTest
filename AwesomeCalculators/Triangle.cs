namespace AwesomeSquareCalculator;

/// <summary>
/// Треугольник
/// </summary>
public class Triangle : IFigure
{
    private readonly int _a;
    private readonly int _b;
    private readonly int _c;

    public Triangle(int a, int b, int c)
    {
        _a = a;
        _b = b;
        _c = c;
        
        ValidateExistence();
    }
    
    /// <summary> Правильный ли треугольник </summary>
    public bool IsRightTriangle =>
        _a * _a + _b * _b == _c * _c ||
        _c * _c + _b * _b == _a * _a ||
        _a * _a + _c * _c == _b * _b;

    /// <inheritdoc />
    public double GetSquare()
    {
        var semiPerimeter = (_a + _b + _c) / 2.0;

        var square = Math.Sqrt(semiPerimeter * (semiPerimeter - _a) * (semiPerimeter - _b) * (semiPerimeter - _c));

        return square;
    }

    private void ValidateExistence()
    {
        if(_a <= 0 && _b <= 0 && _c <= 0)
            throw new ArgumentException();
            
        if (_a + _b <= _c)
            throw new ArgumentException();
        
        if (_a + _c <= _b)
            throw new ArgumentException();
        
        if (_c + _b <= _a)
            throw new ArgumentException();
    }
}