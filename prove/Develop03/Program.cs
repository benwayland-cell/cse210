using System;

class Program
{
    static void Main(string[] args)
    {
        Word testWord = new Word("test");
        Console.WriteLine(testWord);
        testWord.Hide();
        Console.WriteLine(testWord);
        testWord.Show();
        Console.WriteLine(testWord);
    }
}