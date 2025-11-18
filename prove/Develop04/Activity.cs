
public class Activity
{
    private string activityName = "empty activity name";
    private string activityDescription = "empty activity description";
    private int timeOfActivity;
    private DateTime endLoopTime;

    /* Gets how long the user wants the activity to be.
    It also sets timeOfActivity and endLoopTime
    */
    private void GetLengthOfActivityFromUser()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        timeOfActivity = int.Parse(Console.ReadLine());
        
        DateTime startTime = DateTime.Now;
        endLoopTime = startTime.AddSeconds(timeOfActivity);
    }

    /* Counts down from lengthOfTime to 0 with text printed to the console */
    protected void CountDownAnimation(int lengthOfTime)
    {
        
    }

    /* Runs a circular animation for as long as lengthOfTime */
    protected void StallAnimation(int lengthOfTime)
    {
        
    }

    /* Returns whether we have passed when the activity is to end */
    protected bool CheckIfTimeIsUp()
    {
        return DateTime.Now >= endLoopTime;
    }

    public void RunActivity()
    {
        Console.WriteLine($"Welcome to the {activityName}\n\n{activityDescription}");
        RunSpecificActivity();

        Console.WriteLine("Well done!!\n");
        Console.WriteLine($"You have completed another {timeOfActivity} seconds of the {activityName}");
    }

    private void RunSpecificActivity()
    {
        Console.WriteLine("Empty Activity");

        // test things for activity
        GetLengthOfActivityFromUser();
        Console.WriteLine(endLoopTime);
    }

}