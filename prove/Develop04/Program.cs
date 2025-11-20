using System;
using System.Reflection.Metadata;

/*
I exceeded expectations by making it so you don't repeat randomly generated questions in ReflectionActivity.
I also added functionality to log the number of times an activity has been run, and how long in seconds it has been run.
You can also log the saved data to a file.
*/

class Program
{
    public static string[] menuPrompt = [
        "Menu Options:",
        "   1. Start breathing activity",
        "   2. Start reflecting activity",
        "   3. Start listing activity",
        "   4. Log data to file",
        "   5. Quit"
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

    public static void LogDataToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Activity activity in activityList)
            {
                outputFile.WriteLine(activity.GetLogAsString());
            }
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
        int userInput = GetUserInputInBounds(1, 5);

        if (userInput == 5)
        {
            return false;
        }
        else if (userInput == 4)
        {
            Console.Write("\nWhere do you want to log the current data to? ");
            string filename = Console.ReadLine();
            LogDataToFile(filename);
            Console.WriteLine($"Logged the data to '{filename}'.");
            Activity.StallAnimation(5);
            return true;
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