using System;

class Program
{
    static void Main(string[] args)
    {
        Menu journalMenu = new Menu();


        int userSelection = journalMenu.ProcessMenu();

        // JournalEntry testJournalEntry = journalMenu.CreateJournalEntry();
        // testJournalEntry.Display();

        switch (userSelection)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
        }
    }
}