
class Menu
{
    public List<string> _menuStrings = new List<string> {
        "Welcome to the Count",
        "You can create, display, save, and read journal entries",
        "1 - Create Journal Entry",
        "2 - Display Journal",
        "3 - Save Journal to File",
        "4 - Read Journal from file",
        "5 - Quit"
    };

    public List<string> _promptStrings = new List<string> {
        "What made me smile today?",
        "What am I avoiding and why?",
        "What does my ideal day look like?",
        "What am I grateful for right now?",
        "What emotions am I feeling most strongly?",
        "What’s one thing I learned today?",
        "What’s draining my energy lately?",
        "What do I need to let go of?",
        "What’s a recent challenge I overcame?",
        "What does success mean to me?",
        "What habits are helping me grow?",
        "What’s something I’m proud of?",
        "What am I afraid of losing?",
        "What does self-care look like for me?",
        "What’s a memory I cherish?",
        "What’s something I wish others knew about me?",
        "What’s one thing I can do to feel more grounded?",
        "What’s a goal I’m working toward?",
        "What’s something I need to forgive myself for?",
        "What’s inspiring me lately?"
    };

    /* Process Menu will display the menu to the user, and read and validate the input, and return the input.
    Parameters:
        None
    */
    public int ProcessMenu()
    {
        int userSelection = 0;
        do
        {
            foreach (string menuItem in _menuStrings)
            {
                Console.WriteLine(menuItem);
            }
            userSelection = int.Parse(Console.ReadLine());
            Console.WriteLine();
        } while (userSelection < 1 || userSelection > 5);
        return userSelection;
    }

    public JournalEntry CreateJournalEntry()
    {
        /* Gets input from the user and stores the data */

        // get the data to add to the entry
        string date = GetDate();
        string prompt = GetPrompt();
        string entry = GetUserResponse(prompt);

        // set up the journal entry
        JournalEntry entryToAdd = new JournalEntry();
        entryToAdd.Set(date, prompt, entry);

        return entryToAdd;
    }

    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }

    public string GetPrompt()
    {
        Random randomizer = new Random();
        int randomIndex = randomizer.Next(_promptStrings.Count);
        string randomPrompt = _promptStrings[randomIndex];
        return randomPrompt;
    }
    
    public string GetUserResponse(string prompt)
    {
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        Console.WriteLine();
        return response;
    }
}