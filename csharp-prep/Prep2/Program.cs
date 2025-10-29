using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input grade: ");
        int grade = int.Parse(Console.ReadLine());

        string letterSign = "";
        int lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            letterSign = "+";
        }
        else if (lastDigit < 3)
        {
            letterSign = "-";
        }
        

        string letter;
        Boolean passed = true;

        if (grade >= 90)
        {
            letter = "A";
            if (letterSign == "+")
            {
                letterSign = "";
            }
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
            passed = false;
        }
        else
        {
            letter = "F";
            passed = false;
            letterSign = "";
        }

        Console.WriteLine($"Your grade letter: {letter}{letterSign}");

        if (passed)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed :(");
        }
    }
}