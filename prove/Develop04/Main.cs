using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<MindfulnessActivity> activities = new List<MindfulnessActivity>();
        while (true)
        {
            MindfulnessActivity.ShowMenu();
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        var breathingActivity = new BreathingActivity("Breathing", "Relax with breathing", 5);
                        breathingActivity.PerformActivity();
                        activities.Add(breathingActivity);
                        break;
                    case 2:
                        var reflectionActivity = new ReflectionActivity("Reflection", "Reflect on past experiences", 5);
                        reflectionActivity.PerformActivity();
                        activities.Add(reflectionActivity);
                        break;
                    case 3:
                        var listingActivity = new ListingActivity("Listing", "List things that make you happy", 5);
                        listingActivity.PerformActivity();
                        activities.Add(listingActivity);
                        break;
                    case 4:
                        MindfulnessActivity.ShowLog(activities);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please choose a number between 1 and 4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please choose a number between 1 and 4.");
            }
        }
    }
}
