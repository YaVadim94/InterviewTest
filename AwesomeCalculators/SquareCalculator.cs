namespace AwesomeSquareCalculator;

/// <summary>
/// Калькулятор площадей
/// </summary>
public class SquareCalculator : ICalculator
{
    /// <inheritdoc />
    public double Calculate(IFigure figure) => figure.GetSquare();
}