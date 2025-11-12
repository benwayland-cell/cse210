
class Reference
{
    string _book;
    int _chapter;
    int _startVerse;
    int _endVerse;

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = startVerse;
    }

    public override string ToString()
    {
        if (_startVerse != _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        return $"{_book} {_chapter}:{_startVerse}";
    }
}