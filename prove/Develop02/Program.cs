using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the menu and the journal
        Menu journalMenu = new Menu();
        Journal currentJournal = new Journal();

        // the main loop
        bool done = false;
        do
        {
            // Get what the user wants to do
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
                    currentJournal.SaveToFile(journalMenu.GetFileNameFromUser());
                    break;
                case 4:
                    // Read from a file
                    currentJournal.ReadFromFile(journalMenu.GetFileNameFromUser());
                    break;
                case 5:
                    // Quit
                    done = true;
                    break;
            }
            
        } while (!done);
    }
}