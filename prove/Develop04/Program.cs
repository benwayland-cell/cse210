using System;
using System.Reflection.Metadata;

class Program
{
    public static string[] menuPrompt = [
        "Menu Options:",
        "   1. Start breathing activity",
        "   2. Start reflecting activity",
        "   3. Start listing activity",
        "   4. Quit"
    ];

    public static Activity[] activityList = [
        new BreathingActivity(),
        new ReflectionActivity(),
        new ListingActivity()
    ];

    public static int GetUserInputInBounds(int startBound, int endBound)
    {
        string userInputString;
        int userInputInt;
        while (true)
        {
            userInputString = Console.ReadLine();


            if (Int32.TryParse(userInputString, out userInputInt))
            {
                if (startBound <= userInputInt && userInputInt <= endBound)
                {
                    return userInputInt;
                }
            }

            Console.Write($"User input invalid, Try again. ({startBound}-{endBound})");
            
        }
    }

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
        int userInput = GetUserInputInBounds(1, 4);

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