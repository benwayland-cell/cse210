
using System.IO; 

class Journal
{
    public List<JournalEntry> _entryList = new List<JournalEntry>();

    public string _seperator = "~|~";

    /* adds an entry to _entryList */
    public void AddEntry(JournalEntry entryToAdd)
    {
        // Add the entry to the list
        _entryList.Add(entryToAdd);
    }

    /* Displays the journal entries in _entryList */
    public void Display()
    {
        foreach (JournalEntry entry in _entryList)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    /* saves the list of journal entries into a file at filename */
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entryList)
            {
                outputFile.WriteLine($"{entry._date}{_seperator}{entry._prompt}{_seperator}{entry._entry}");
            }
        }
    }

    /* replaces the current _entryList with one from the given file*/
    public void ReadFromFile(string filename)
    {
        int dateIndex = 0;
        int promptIndex = 1;
        int entryIndex = 2;

        // Reset the entry list
        _entryList = new List<JournalEntry>();

        // Get the lines in the file
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(_seperator);

            // make a journal entry based off of what we read
            JournalEntry journalEntryToAdd = new JournalEntry();
            journalEntryToAdd._date = parts[dateIndex];
            journalEntryToAdd._prompt = parts[promptIndex];
            journalEntryToAdd._entry = parts[entryIndex];

            _entryList.Add(journalEntryToAdd);
        }
    }
}