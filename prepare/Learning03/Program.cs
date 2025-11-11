using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction testFraction1 = new Fraction();
        Fraction testFraction2 = new Fraction(5);
        Fraction testFraction3 = new Fraction(2, 10);

        Console.WriteLine(testFraction1.GetNumerator());
        Console.WriteLine(testFraction1.GetDenominator());
        testFraction1.SetNumerator(5);
        testFraction1.SetDenominator(4);
        Console.WriteLine(testFraction1.GetFractionString());
        Console.WriteLine(testFraction1.GetDecimalValue());
        Console.WriteLine();

        Console.WriteLine(testFraction2.GetNumerator());
        Console.WriteLine(testFraction2.GetDenominator());
        testFraction2.SetNumerator(100);
        testFraction2.SetDenominator(4);
        Console.WriteLine(testFraction2.GetFractionString());
        Console.WriteLine(testFraction2.GetDecimalValue());
        Console.WriteLine();

        Console.WriteLine(testFraction3.GetNumerator());
        Console.WriteLine(testFraction3.GetDenominator());
        testFraction3.SetNumerator(2);
        testFraction3.SetDenominator(1);
        Console.WriteLine(testFraction3.GetFractionString());
        Console.WriteLine(testFraction3.GetDecimalValue());
        Console.WriteLine();

        testFraction2.Simplify();
        Console.WriteLine(testFraction2.GetFractionString());
    }
}