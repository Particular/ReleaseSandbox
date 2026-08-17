namespace TotallyLegit;

/// <summary>
/// Calculator
/// </summary>
public class Calculator
{
    int _result;

    /// <summary>
    /// GetTotal
    /// </summary>
    /// <returns></returns>
    public int GetTotal()
    {
        return _result;
    }

    /// <summary>
    /// Add
    /// </summary>
    /// <param name="nextNumber"></param>
    /// <returns></returns>
    public int Add(int nextNumber)
    {
        return _result += nextNumber;
    }

    /// <summary>
    /// Subtract
    /// </summary>
    /// <param name="nextNumber"></param>
    /// <returns></returns>
    public int Subtract(int nextNumber)
    {
        return _result -= nextNumber;
    }

    /// <summary>
    /// Multiply
    /// </summary>
    /// <param name="nextNumber"></param>
    /// <returns></returns>
    public int Multiply(int nextNumber)
    {
        return _result *= nextNumber;
    }
}
