
class Word
{
    private string _text;
    private bool _hidden = false;
    private string hiddenString = "";

    public Word(string text)
    {
        _text = text;

        // make the hiddenString a string that just is a string that has
        // as many underscores as the length of text.
        for (int i = 0; i < _text.Count(); i++)
        {
            hiddenString += "_";
        }
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public override string ToString()
    {
        // if it's not hidden, just return the text
        if (!_hidden)
        {
            return _text;
        }
        // return the hidden string
        return hiddenString;
    }
}