
using System.Globalization;

public class ReflectionActivity : Activity
{
    private const string activityName = "Reflection Activity";
    private const string activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
    private string[] promptList = [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    ];

    private string[] questionList = [
        "Why was this experience meaningful to you? ",
        "Have you ever done anything like this before? ",
        "How did you get started? ",
        "How did you feel when it was complete? ",
        "What made this time different than other times when you were not as successful? ",
        "What is your favorite thing about this experience? ",
        "What could you learn from this experience that applies to other situations? ",
        "What did you learn about yourself through this experience? ",
        "How can you keep this experience in mind in the future? "
    ];

    public ReflectionActivity() : base(activityName, activityDescription){}

    protected override void RunSpecificActivity()
    {
        // get randomizer
        Random random = new Random();
        
        // display the prompt
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n --- {promptList[random.Next(promptList.Count())]} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        
        // wait for an enter from the user
        Console.ReadLine();

        // display message to prompt the user to start the activity
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        CountDownAnimation(5);

        Console.Clear();
        StartTimer();

        while (!CheckIfTimeIsUp())
        {
            // print a random question
            Console.Write(questionList[random.Next(questionList.Count())]);
            StallAnimation(15);
        }
        Console.WriteLine();
    }
}