
using System.ComponentModel.DataAnnotations;

class Scripture
{
    private Reference _reference;
    private List<List<Word>> _text;

    public Scripture(Reference reference, List<List<Word>> text)
    {
        _reference = reference;
        _text = text;
    }

    public void Display()
    {
        // Console.Clear();
        Console.WriteLine(_reference);

        int verseNum = _reference.GetStartVerse();
        foreach (List<Word> verse in _text)
        {
            Console.Write($"{verseNum}. ");
            foreach (Word word in verse)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine();
            verseNum++;
        }
    }
}