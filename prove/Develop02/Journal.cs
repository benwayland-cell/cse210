
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
}