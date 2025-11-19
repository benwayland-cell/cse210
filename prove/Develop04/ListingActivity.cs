
public class ListingActivity : Activity
{
    private const string activityName = "Listing Activity";
    private const string activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    
    private string[] promptList = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];

    public ListingActivity() : base(activityName, activityDescription){}

    protected override void RunSpecificActivity()
    {
        Random random = new Random();
        
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {promptList[random.Next(promptList.Length)]} ---");

        Console.Write("You may begin in: ");
        CountDownAnimation(5);
        Console.WriteLine();

        StartTimer();
        int count = 0;
        while (!CheckIfTimeIsUp())
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items!\n");
    }
}