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
                    // Create a journal entry
                    JournalEntry newEntry = journalMenu.CreateJournalEntry();
                    currentJournal.AddEntry(newEntry);
                    break;
                case 2:
                    // display journal
                    currentJournal.Display();
                    break;
                case 3:
                    // Save to a file
                    currentJournal.SaveToFile("test");
                    break;
                case 4:
                    // Read from a file
                    break;
                case 5:
                    // Quit
                    done = true;
                    break;
            }
            
        } while (!done);
    }
}