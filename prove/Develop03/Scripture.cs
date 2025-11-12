
using System.ComponentModel.DataAnnotations;

class Scripture
{
    private Reference _reference;
    private List<Word> _text;

    public Scripture(Reference reference, List<Word> text)
    {
        _reference = reference;
        _text = text;
    }

    public void Display()
    {
        foreach(Word word in _text)
        {
            Console.Write(word);
        }
    }
}