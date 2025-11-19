
public class BreathingActivity : Activity
{

    private const string activityName = "Breathing Activity";
    private const string activityDescription = "description";

    public BreathingActivity() : base(activityName, activityDescription){}

    protected override void RunSpecificActivity()
    {
        Console.WriteLine("Run Breathing Activity\n");
    }
}