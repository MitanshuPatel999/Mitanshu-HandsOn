using MyNamespace; // Import the namespace
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Result: " + Calculator.Add(10, 5));
        Console.WriteLine("Result: " + Calculator.Add(10, 5, 20));
        Console.WriteLine("Result: " + Calculator.Sub(10, 5));
        Console.WriteLine("Result: " + Calculator.Mul(10, 5));
        Console.WriteLine("Result: " + Calculator.Div(10, 5));

      }
}
