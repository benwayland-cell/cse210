
using System.IO;
using System.Runtime.InteropServices;

class Journal
{
    public List<JournalEntry> _entryList = new List<JournalEntry>();

    const int dateIndex = 0;
    const int promptIndex = 1;
    const int entryIndex = 2;
    const int spaceIndex = 3;

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
                outputFile.WriteLine($"{entry._date}\n{entry._prompt}\n{entry._entry}\n");
            }
        }
    }

    /* replaces the current _entryList with one from the given file*/
    public void ReadFromFile(string filename)
    {
        // Reset the entry list
        _entryList = new List<JournalEntry>();

        // Get the lines in the file
        string[] lines = System.IO.File.ReadAllLines(filename);

        // init the journal which we will add to the _entryList
        JournalEntry journalEntryToAdd = new JournalEntry();

        // for every line in the file
        for (int fileIndex = 0; fileIndex < lines.Length; fileIndex++)
        {
            string line = lines[fileIndex];

            // depending on what line it is it will do something different
            switch (fileIndex % (spaceIndex + 1))
            {
                case dateIndex:
                    // this line is the date
                    journalEntryToAdd._date = line;
                    break;
                case promptIndex:
                    // this line is the prompt
                    journalEntryToAdd._prompt = line;
                    break;
                case entryIndex:
                    // this line is the entry
                    journalEntryToAdd._entry = line;
                    break;
                case spaceIndex:
                    // this line is the space
                    // we also add the journalEntryToAdd to the _entryList
                    _entryList.Add(journalEntryToAdd);
                    journalEntryToAdd = new JournalEntry();
                    break;
            }
        }
    }
}