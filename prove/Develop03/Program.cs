using System.IO;
using System.Runtime.InteropServices;

class Program
{
    /* Takes all of the scriptures in "filename" and puts it into a list of scriptures */
    static List<Scripture> ConvertFileToScriptures(string filename)
    {
        // init the list of scriptures we will return
        List<Scripture> scriptureList = new List<Scripture>();

        // Get the lines in the file
        string[] lines = System.IO.File.ReadAllLines(filename);

        // initialization for the loop

        // is true if the next line will start a new scripture
        bool nextLineNewScripture = true;
        // where we'll store the reference that we will add
        Reference newReference = null;
        // where we'll store the verses that we will add
        List<List<Word>> newVerses = new List<List<Word>>();

        foreach (string line in lines)
        {
            if (line == "" && newReference != null && newVerses.Count > 0)
            {
                // we're at a dividing empty line so we add the scripture to the list

                // add the current data we have to a new scripture in scriptureList
                scriptureList.Add(new Scripture(newReference, newVerses));
                newReference = null;
                newVerses = new List<List<Word>>();
                
                nextLineNewScripture = true;
            }
            else if (nextLineNewScripture)
            {
                // we are now looking at the reference and need to parse it
                newReference = StringToReference(line);
                nextLineNewScripture = false;
            }
            else
            {
                // we are looking at a line that has a verse
                newVerses.Add(StringToVerse(line));
            }
        }

        // add the current data for a scripture in case we haven't added it yet
        if (newReference != null && newVerses.Count > 0)
        {
            scriptureList.Add(new Scripture(newReference, newVerses));
        }

        return scriptureList;
    }

    /* Converts a string to a reference
    The string must be formatted like:
    Book chapter:startVerse-endVerse
    or like:
    Book chapter:startVerse

    e.g.
    1 Nephi 3:7-8
    Mosiah 2:17

    Parameters:
        string referenceString: the string that we will be converting
    Return:
        A Reference object with the correct attributes
     */
    static Reference StringToReference(string referenceString)
    {
        // the book and the numbers after it
        // the next loop will find these two
        string book = "";
        string referenceNumbers = "";

        // search for the first number in the reference, ignore the first
        // (because it could be something like "1 Nephi")
        for (int charIndex = 1; charIndex < referenceString.Count(); charIndex++)
        {
            char currentChar = referenceString[charIndex];
            if (Char.IsNumber(currentChar))
            {
                // splice the line into the book and reference numbers
                book = referenceString.Substring(0, charIndex);
                referenceNumbers = referenceString.Substring(charIndex);
                break;
            }
        }

        // splice the reference numbers so we can get the chapter and verses
        string[] referenceNumbersSplit = referenceNumbers.Split(":");
        int chapter = int.Parse(referenceNumbersSplit[0].Trim());
        string verses = referenceNumbersSplit[1].Trim();

        // get the start and end verse from verses
        int startVerse;
        int endVerse;

        if (!verses.Contains("-"))
        {
            startVerse = int.Parse(verses);
            endVerse = startVerse;
        }
        else
        {
            string[] versesSplit = verses.Split("-");
            startVerse = int.Parse(versesSplit[0].Trim());
            endVerse = int.Parse(versesSplit[1].Trim());
        }



        book = book.Trim();

        return new Reference(book, chapter, startVerse, endVerse);
    }

    /* Converts a string of a verse into a list of Word objects*/
    static List<Word> StringToVerse(string verseString)
    {
        string[] words = verseString.Split(" ");

        List<Word> willReturn = new List<Word>();
        foreach (string word in words)
        {
            willReturn.Add(new Word(word));
        }

        return willReturn;
    }

    static void Main(string[] args)
    {
        // Word testWord = new Word("test");
        // Console.WriteLine(testWord);
        // testWord.Hide();
        // Console.WriteLine(testWord);
        // testWord.Show();
        // Console.WriteLine(testWord);


        // Reference testReference1 = new Reference("Book", 2, 1, 3);
        // Console.WriteLine(testReference1);
        // Reference testReference2 = new Reference("Book2", 4, 5);
        // Console.WriteLine(testReference2);


        // List<Word> testWordList1 = new List<Word>
        // {
        //     new Word("word1"),
        //     new Word("word2"),
        //     new Word("word3")
        // };
        // List<Word> testWordList2 = new List<Word>
        // {
        //     new Word("word5"),
        //     new Word("word6"),
        //     new Word("word7")
        // };

        // List<List<Word>> testVersesList = new List<List<Word>>
        // {
        //     testWordList1,
        //     testWordList2
        // };

        // Scripture testScripture = new Scripture(testReference1, testVersesList);
        // testScripture.Display();

        // testWordList1[1].Hide();

        // testScripture.Display();


        // Console.WriteLine(StringToReference("1 Nephi    3   :    7    -   8    "));


        // string testString = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        // List<Word> testVerse = StringToVerse(testString);

        // testVerse[3].Hide();

        // foreach (Word word in testVerse)
        // {
        //     Console.Write(word);
        // }

        List<Scripture> testScriptureList = ConvertFileToScriptures("test");

        foreach (Scripture scripture in testScriptureList)
        {
            scripture.Display();
            Console.WriteLine();
        }
    }
}