using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);
        Console.WriteLine(magic_number);

        int guess;

        while (true)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess == magic_number)
            {
                Console.WriteLine("You guessed it!");
                Console.Write("Play again? ");
                if (Console.ReadLine() != "yes")
                {
                    break;
                }
            }
            else if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
        }
    }
}