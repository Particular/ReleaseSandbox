using TotallyLegit;

Console.WriteLine("TotallyLegit Calculator - Example Usage");
Console.WriteLine();

var calculator = new Calculator();

Console.WriteLine($"Add(5) -> {calculator.Add(5)}");
Console.WriteLine($"Add(10) -> {calculator.Add(10)}");
Console.WriteLine($"Subtract(3) -> {calculator.Subtract(3)}");
Console.WriteLine($"Multiply(4) -> {calculator.Multiply(4)}");
Console.WriteLine();
Console.WriteLine($"Final total: {calculator.GetTotal()}");
