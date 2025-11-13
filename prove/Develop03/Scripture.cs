
using System.ComponentModel.DataAnnotations;

class Scripture
{
    private Reference _reference;
    private List<List<Word>> _text;

    private const int numOfWordsToHide = 3;

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

    /* Hides as many words as "numOfHiddenWords" in "_text".
    Return:
        returns false by default
        returns true when all of the words are hidden after this
     */
    public bool HideWords()
    {
        List<List<int>> notHiddenIndices = GetNotHiddenWordsIndices();

        // Get the random number generator
        Random random = new Random();

        for (int i = 0; i < numOfWordsToHide; i++)
        {
            // get a word to hide
            int randomIndex = random.Next(notHiddenIndices.Count);
            List<int> wordToHideIndices = notHiddenIndices[randomIndex];

            // remove it from the not hidden words
            notHiddenIndices.Remove(wordToHideIndices);

            // hide the word
            _text[wordToHideIndices[0]][wordToHideIndices[1]].Hide();

            // if all words are hidde, end and return true
            if (notHiddenIndices.Count == 0)
            {
                return true;
            }
        }

        return false;
    }

    /* Returns a list of indexes for each word that is not hidden
    Return:
        A list of the indices of not hidden words
        Each item is formatted like this:
        {verseIndex, wordIndex}
    */
    private List<List<int>> GetNotHiddenWordsIndices()
    {
        List<List<int>> notHiddenIndices = new List<List<int>>();
        
        for (int verseIndex = 0; verseIndex < _text.Count; verseIndex++)
        {
            List<Word> verse = _text[verseIndex];
            for (int wordIndex = 0; wordIndex < verse.Count; wordIndex++)
            {
                Word word = verse[wordIndex];
                if (!word.IsHidden())
                {
                    notHiddenIndices.Add(new List<int>{verseIndex, wordIndex});
                }
            }
        }

        return notHiddenIndices;
    }
}