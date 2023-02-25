using System;

public abstract class MindfulnessActivity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int CompletedCount { get; protected set; }

    protected MindfulnessActivity(string name, string description)
    {
        Name = name;
        Description = description;
        CompletedCount = 0;
    }

    public void IncrementCompletedCount()
    {
        CompletedCount++;
    }

    public static void ShowLog(List<MindfulnessActivity> activities)
    {
        Console.WriteLine("Completed activities:");
        foreach (var activity in activities)
        {
            if (activity is BreathingActivity breathingActivity)
            {
                Console.WriteLine($"{breathingActivity.Name}: {breathingActivity.BreathingCompletedCount} times");
            }
            else if (activity is ReflectionActivity reflectionActivity)
            {
                Console.WriteLine($"{reflectionActivity.Name}: {reflectionActivity.ReflectionCompletedCount} times");
            }
            else if (activity is ListingActivity listingActivity)
            {
                Console.WriteLine($"{listingActivity.Name}: {listingActivity.ListingCompletedCount} times");
            }
            else
            {
                Console.WriteLine($"{activity.Name}: {activity.CompletedCount} times");
            }
        }
    }

    public static void ShowLoadingMessage()
    {
        Console.WriteLine("Please wait...namaste...");
    }

    public abstract void PerformActivity();

    public static void ShowMenu()
    {
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Show Log");
    }
}