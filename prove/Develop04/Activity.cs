
public class Activity
{
    private string _activityName = "Empty Activity Name";
    private string _activityDescription = "Empty Activity Description";
    private int _timeOfActivity;
    private DateTime _endLoopTime;

    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    /* Gets how long the user wants the activity to be.
    It also sets _timeOfActivity and _endLoopTime
    */
    private void GetLengthOfActivityFromUser()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _timeOfActivity = int.Parse(Console.ReadLine());
        
        DateTime startTime = DateTime.Now;
        _endLoopTime = startTime.AddSeconds(_timeOfActivity);
        Console.WriteLine();
    }

    /* Counts down from lengthOfTime to 0 with text printed to the console */
    protected void CountDownAnimation(int lengthOfTime)
    {
        for (int currentNum = lengthOfTime; currentNum > 0; currentNum--)
        {
            Console.Write($"{currentNum}\b");
            Thread.Sleep(1000);
        }
        Console.WriteLine(" ");
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
        return DateTime.Now >= _endLoopTime;
    }

    /* Runs things that all activities do and runs the specific method for each activity */
    public void RunActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}\n\n{_activityDescription}\n");
        GetLengthOfActivityFromUser();
        RunSpecificActivity();

        Console.WriteLine("Well done!!\n");
        Console.WriteLine($"You have completed another {_timeOfActivity} seconds of the {_activityName}.");
    }

    protected virtual void RunSpecificActivity()
    {
        Console.WriteLine("Empty Activity");

        // test things for activity

        // GetLengthOfActivityFromUser();
        // Console.WriteLine(_endLoopTime);
        // Thread.Sleep(2000);
        // Console.WriteLine(CheckIfTimeIsUp());

        // StallAnimation(5);

        // CountDownAnimation(5);
    }

}