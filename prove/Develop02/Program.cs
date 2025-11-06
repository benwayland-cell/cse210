using System;

class Program
{
    static void Main(string[] args)
    {
        Menu journalMenu = new Menu();

        journalMenu.PrintMenu();

        JournalEntry testJournalEntry = journalMenu.CreateJournalEntry();
        testJournalEntry.Display();
    }
}