using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Assignment testAssignment = new Assignment("Test assignment name", "Test assignment topic");
        Console.WriteLine(testAssignment.GetSummary());
        Console.WriteLine();

        MathAssignment testMathAssignment = new MathAssignment("Test math name", "Test math topic", "7.3", "3-10");
        Console.WriteLine(testMathAssignment.GetSummary());
        Console.WriteLine(testMathAssignment.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment testWritingAssignment = new WritingAssignment("Test writing name", "Test writing topic", "Test writing title");
        Console.WriteLine(testWritingAssignment.GetSummary());
        Console.WriteLine(testWritingAssignment.GetWritingInformation());
        Console.WriteLine();
    }
}