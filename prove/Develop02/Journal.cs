
class Journal
{
    public List<Journal> _entryList;

    public void Display()
    {
        foreach (Journal entry in _entryList)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
}