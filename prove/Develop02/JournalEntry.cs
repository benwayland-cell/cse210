
class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _entry;

    public void Set(string date, string prompt, string entry)
    {
        _date = date;
        _prompt = prompt;
        _entry = entry;
    }

    public void Display()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        Console.WriteLine(_entry);
    }
}