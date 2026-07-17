namespace TotallyLegit;

/// <summary>
/// A simple running-total calculator.
/// </summary>
public class Calculator
{
    int _result;

    /// <summary>
    /// Gets the current running total.
    /// </summary>
    /// <returns>The current running total.</returns>
    public int GetTotal()
    {
        return _result;
    }

    /// <summary>
    /// Adds a number to the running total.
    /// </summary>
    /// <param name="nextNumber">The number to add.</param>
    /// <returns>The updated running total.</returns>
    public int Add(int nextNumber)
    {
        return _result += nextNumber;
    }

    /// <summary>
    /// Subtracts a number from the running total.
    /// </summary>
    /// <param name="nextNumber">The number to subtract.</param>
    /// <returns>The updated running total.</returns>
    public int Subtract(int nextNumber)
    {
        return _result -= nextNumber;
    }

    /// <summary>
    /// Multiplies the running total by a number.
    /// </summary>
    /// <param name="nextNumber">The number to multiply by.</param>
    /// <returns>The updated running total.</returns>
    public int Multiply(int nextNumber)
    {
        return _result *= nextNumber;
    }
}
