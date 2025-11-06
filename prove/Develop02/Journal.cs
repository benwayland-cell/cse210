
class Journal
{
    public List<JournalEntry> _entryList = new List<JournalEntry>();

    public void AddEntry(JournalEntry entryToAdd)
    {   
        // /* Gets input from the user and stores the data */
        
        // // get the data to add to the entry
        // string date = "11/5/2025";
        // Console.Write("Prompt: ");
        // string prompt = Console.ReadLine();
        // Console.Write("Entry: ");
        // string entry = Console.ReadLine();

        // // set up the journal entry
        // JournalEntry entryToAdd = new JournalEntry();
        // entryToAdd.Set(date, prompt, entry);

        // Add the entry to the list
        _entryList.Add(entryToAdd);
    }

    public void Display()
    {
        foreach (JournalEntry entry in _entryList)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
}