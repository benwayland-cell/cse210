using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment testAssignment = new Assignment("test name", "test topic");
        // Console.WriteLine(testAssignment.GetSummary());

        MathAssignment testMathAssignment = new MathAssignment("test name", "test topic", "7.3", "3-10");
        Console.WriteLine(testMathAssignment.GetSummary());
        Console.WriteLine(testMathAssignment.GetHomeworkList());

        
    }
}