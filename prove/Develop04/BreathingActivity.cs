
public class BreathingActivity : Activity
{

    private const string activityName = "Breathing Activity";
    private const string activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public BreathingActivity() : base(activityName, activityDescription){}

    protected override void RunSpecificActivity()
    {
        // Ask the user to ready themselves
        Console.Clear();
        Console.WriteLine("Get ready...");
        StallAnimation(5);

        // start the activity timer
        StartTimer();

        // loop until the time is up
        while (!CheckIfTimeIsUp())
        {
            Console.Write("Breath in...");
            CountDownAnimation(4);
            Console.Write("Now breathe out...");
            CountDownAnimation(6);
            Console.WriteLine();
        }

    }
}