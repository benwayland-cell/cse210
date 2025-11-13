using System.IO;
using System.Runtime.InteropServices;

class Program
{
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

        List<Scripture> testScriptureList = UserInterface.ConvertFileToScriptures("test");

        // foreach (Scripture scripture in testScriptureList)
        // {
        //     scripture.Display();
        //     Console.WriteLine();
        // }

        // testScriptureList[1].Display();
        // bool done = false;
        // while (!done)
        // {
        //     Console.WriteLine();
        //     done = testScriptureList[1].HideWords();
        //     testScriptureList[1].Display();
        // }

        UserInterface.RunMemorizeScripture(testScriptureList[1]);
    }
}