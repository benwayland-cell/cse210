
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
        _timeOfActivity = Program.GetUserInputInBounds(0, 9999999);
        Console.WriteLine();
    }

    protected void StartTimer()
    {
        DateTime startTime = DateTime.Now;
        _endLoopTime = startTime.AddSeconds(_timeOfActivity);
    }

    /* Counts down from duration to 0 with text printed to the console */
    protected void CountDownAnimation(int duration)
    {
        Console.CursorVisible = false;

        for (int currentNum = duration; currentNum > 0; currentNum--)
        {
            Console.Write($"{currentNum}\b");
            Thread.Sleep(1000);
        }
        Console.WriteLine(" ");

        Console.CursorVisible = true;
    }

    /* Runs a circular animation for as long as duration */
    protected void StallAnimation(int duration)
    {
        Console.CursorVisible = false;
        
        int sleepTime = 500;
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        string animationFrames = "|/-\\";

        for (int animationIndex = 0; DateTime.Now < endTime; animationIndex = ++animationIndex % animationFrames.Length)
        {
            Console.Write($"{animationFrames[animationIndex]}\b");
            Thread.Sleep(sleepTime);
        }
        Console.WriteLine(" ");

        Console.CursorVisible = true;
    }

    /* Returns whether we have passed when the activity is to end */
    protected bool CheckIfTimeIsUp()
    {
        return DateTime.Now >= _endLoopTime;
    }

    /* Makes a duplicate of a string[] a List<string> so you can manipulate it seperately */
    protected List<string> MakeDuplicate(string[] givenList)
    {
        List<string> newList = new List<string>();

        foreach (String str in givenList)
        {
            newList.Add(str);
        }

        return newList;
    }

    /* Returns a random element in the List<string> and also removes that string from the list. */
    protected string GetAndPopList(ref List<string> givenList)
    {
        Random random = new Random();
        int randomIndex = random.Next(givenList.Count());
        string currentQuestion = givenList[randomIndex];
        givenList.RemoveAt(randomIndex);

        return currentQuestion;
    }

    /* Runs things that all activities do and runs the specific method for each activity */
    public void RunActivity()
    {
        // display activity info
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}\n");
        Console.WriteLine($"{_activityDescription}\n");
        GetLengthOfActivityFromUser();

        // Ask the user to ready themselves
        Console.Clear();
        Console.WriteLine("Get ready...");
        StallAnimation(5);

        RunSpecificActivity();

        // display ending message
        Console.WriteLine("Well done!!");
        StallAnimation(5);
        Console.WriteLine($"You have completed another {_timeOfActivity} seconds of the {_activityName}.");
        StallAnimation(5);
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