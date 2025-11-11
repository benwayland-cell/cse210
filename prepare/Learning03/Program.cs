using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction testFraction1 = new Fraction();
        Fraction testFraction2 = new Fraction(5);
        Fraction testFraction3 = new Fraction(5, 10);

        Console.WriteLine(testFraction1.GetFractionString());
        Console.WriteLine(testFraction1.GetDecimalValue());

        Console.WriteLine(testFraction2.GetFractionString());
        Console.WriteLine(testFraction2.GetDecimalValue());

        Console.WriteLine(testFraction3.GetFractionString());
        Console.WriteLine(testFraction3.GetDecimalValue());
    }
}