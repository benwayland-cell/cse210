using System;

class Program
{
    static void Main(string[] args)
    {
        Menu journalMenu = new Menu();

        JournalEntry testJournalEntry = journalMenu.CreateJournalEntry();
        testJournalEntry.Display();

        // int userSelection = journalMenu.ProcessMenu();

        /*bool done = false;
        do
        {
            switch (userSelection)
            {
                case 1:
                // Create a new Entry Object
                // Call create on that object
                // Add the entry to the journal
                    break;
                case 2:
                // Call journal.Display
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
            
        } while (!done);*/
    }
}