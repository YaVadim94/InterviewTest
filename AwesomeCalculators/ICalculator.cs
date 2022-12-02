namespace AwesomeSquareCalculator;

/// <summary>
/// Калькулятор параметров
/// </summary>
public interface ICalculator
{
    /// <summary>
    /// Рассчитать параметр
    /// </summary>
    double Calculate(IFigure figure);
}