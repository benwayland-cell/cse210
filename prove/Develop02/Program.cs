using System;

class Program
{
    static void Main(string[] args)
    {
        Menu journalMenu = new Menu();
        Journal currentJournal = new Journal();

        // JournalEntry testJournalEntry = journalMenu.CreateJournalEntry();
        // testJournalEntry.Display();


        bool done = false;
        do
        {
            int userSelection = journalMenu.ProcessMenu();

            switch (userSelection)
            {
                case 1:
                    // Create a new Entry Object
                    // Call create on that object
                    // Add the entry to the journal
                    JournalEntry newEntry = journalMenu.CreateJournalEntry();
                    currentJournal.AddEntry(newEntry);
                    break;
                case 2:
                    // Call journal.Display
                    currentJournal.Display();
                    break;
                case 3:
                    // Save to a file
                    break;
                case 4:
                    // Read from a file
                    break;
                case 5:
                    // Quit
                    break;
            }
            
        } while (!done);
    }
}