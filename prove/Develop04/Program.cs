using System;
using System.Reflection.Metadata;

class Program
{
    public static string[] menuPrompt = [
        "Menu Options:",
        "\t1. Start breathing activity",
        "\t2. Start reflecting activity",
        "\t3. Start listing activity",
        "\t4. Quit"
    ];

    public static Activity[] activityList = [
        new BreathingActivity(),
        new ReflectionActivity(),
        new ListingActivity()
    ];

    static void Main(string[] args)
    {
        while (RunMenu());
    }
    
    /* Runs the menu, letting the user choose an activity from a list of activities
    Return:
        Returns true if the loop should keep going, and false if it shouldn't
     */
    public static bool RunMenu()
    {
        PrintMenu();
        Console.Write("Select a choice from the menu: ");
        int userInput = int.Parse(Console.ReadLine());

        if (userInput == 4)
        {
            return false;
        }

        activityList[userInput - 1].RunActivity();

        return true;
    }

    /* Prints the menu in menuPrompt */
    public static void PrintMenu()
    {
        Console.Clear();
        foreach (string line in menuPrompt)
        {
            Console.WriteLine(line);
        }
    }
}