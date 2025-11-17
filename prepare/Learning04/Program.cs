using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment testAssignment = new Assignment("test name", "test topic");
        Console.WriteLine(testAssignment.GetSummary());
    }
}