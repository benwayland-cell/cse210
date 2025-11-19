
public class ReflectionActivity : Activity
{
    private const string activityName = "Reflection Activity";
    private const string activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";

    public ReflectionActivity() : base(activityName, activityDescription){}

    protected override void RunSpecificActivity()
    {
        Console.WriteLine("Run reflection");
    }
}