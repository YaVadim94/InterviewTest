namespace AwesomeSquareCalculator;

/// <summary>
/// Окружность
/// </summary>
public class Circle : IFigure
{
    private readonly int _radius;

    public Circle(int radius)
    {
        _radius = radius;
        
        ValidateExistence();
    }

    /// <inheritdoc />
    public double GetSquare() => _radius * _radius * Math.PI;

    private void ValidateExistence()
    {
        if (_radius <= 0)
            throw new ArgumentException();
    }
}