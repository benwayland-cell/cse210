
public class Activity
{
    private string activityName = "Empty Activity Name";
    private string activityDescription = "Empty Activity Description";
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
        Console.WriteLine();
    }

    /* Counts down from lengthOfTime to 0 with text printed to the console */
    protected void CountDownAnimation(int lengthOfTime)
    {
        
    }

    /* Runs a circular animation for as long as lengthOfTime */
    protected void StallAnimation(int lengthOfTime)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(lengthOfTime);

        string[] animationFrames = ["|", "/", "-", "\\"];

        for (int animationIndex = 0; DateTime.Now < endTime; animationIndex++)
        {
            
            Console.Write($"{animationFrames[animationIndex % animationFrames.Count()]}\b");
            Thread.Sleep(500);
        }
        Console.WriteLine(" ");
    }

    /* Returns whether we have passed when the activity is to end */
    protected bool CheckIfTimeIsUp()
    {
        return DateTime.Now >= endLoopTime;
    }

    /* Runs things that all activities do and runs the specific method for each activity */
    public void RunActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {activityName}\n\n{activityDescription}\n");
        GetLengthOfActivityFromUser();
        RunSpecificActivity();

        Console.WriteLine("\nWell done!!\n");
        Console.WriteLine($"You have completed another {timeOfActivity} seconds of the {activityName}.");
    }

    private void RunSpecificActivity()
    {
        Console.WriteLine("Empty Activity");

        // test things for activity

        // GetLengthOfActivityFromUser();
        // Console.WriteLine(endLoopTime);
        // Thread.Sleep(2000);
        // Console.WriteLine(CheckIfTimeIsUp());

        // StallAnimation(5);

        
    }

}