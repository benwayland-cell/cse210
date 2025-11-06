
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

    /* Process Menu will display the menu to the user, and read and validate the input and return the input.
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
        string date = "11/5/2025";
        Console.Write("Prompt: ");
        string prompt = Console.ReadLine();
        Console.Write("Entry: ");
        string entry = Console.ReadLine();

        // set up the journal entry
        JournalEntry entryToAdd = new JournalEntry();
        entryToAdd.Set(date, prompt, entry);

        return entryToAdd;
    }
}