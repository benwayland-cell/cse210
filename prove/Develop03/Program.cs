using System;

class Program
{
    static void Main(string[] args)
    {
        // Word testWord = new Word("test");
        // Console.WriteLine(testWord);
        // testWord.Hide();
        // Console.WriteLine(testWord);
        // testWord.Show();
        // Console.WriteLine(testWord);

        Reference testReference1 = new Reference("Book", 2, 1, 3);
        Console.WriteLine(testReference1);
        Reference testReference2 = new Reference("Book2", 4, 5);
        Console.WriteLine(testReference2);
    }
}