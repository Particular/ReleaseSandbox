namespace TotallyLegit;

public class Calculator
{
    int _result;

    public int GetTotal()
    {
        return _result;
    }

    public int Add(int nextNumber)
    {
        return _result += nextNumber;
    }

    public int Subtract(int nextNumber)
    {
        return _result -= nextNumber;
    }

    public int Multiply(int nextNumber)
    {
        return _result *= nextNumber;
    }
}
