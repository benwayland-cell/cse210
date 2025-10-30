using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static void PromtUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResult(string name, int number, int birthYear)
    {
        Console.WriteLine($"{name}, the sqaure of your number is {number}");
        Console.WriteLine($"{name}, you will turn {2025 - birthYear} this year.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int user_number = PromptUserNumber();
        int birthYear;
        PromtUserBirthYear(out birthYear);

        DisplayResult(name, SquareNumber(user_number), birthYear);
    }
}