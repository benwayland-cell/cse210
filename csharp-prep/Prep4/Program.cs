using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> number_list = new List<int>();

        int user_input;
        while (true)
        {
            Console.Write("Enter number: ");
            user_input = int.Parse(Console.ReadLine());

            if (user_input == 0)
            {
                break;
            }
            number_list.Add(user_input);
        }

        int sum = 0;
        int largest_number = number_list[0];
        foreach (int number in number_list)
        {
            sum += number;
            if (number > largest_number)
            {
                largest_number = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {(float)sum / number_list.Count}");
        Console.WriteLine($"The largest number is: {largest_number}");
    }
}