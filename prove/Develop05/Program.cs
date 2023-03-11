using System;
using System.Collections.Generic;
using System.IO;

class Program
{
public static void Main(string[] args)
{
    User user = new User("John Doe");
    GameManager gameManager = new GameManager(user);

    bool isRunning = true;
    while (isRunning)
    {
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Add a new goal");
        Console.WriteLine("2. Add a completed activity");
        Console.WriteLine("3. View completed goals");
        Console.WriteLine("4. View score");
        Console.WriteLine("5. Exit");

        string userInput = Console.ReadLine();
        int option;
        if (!int.TryParse(userInput, out option))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            continue;
        }

        switch (option)
        {
            case 1:
                Console.Write("Enter goal name: ");
                string goalName = Console.ReadLine();
                Console.Write("Enter goal description: ");
                string goalDescription = Console.ReadLine();
                Console.Write("Enter target completion count: ");
                int targetCompletionCount;
                if (!int.TryParse(Console.ReadLine(), out targetCompletionCount))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                gameManager.AddNewGoal(goalName, goalDescription, targetCompletionCount);
                Console.WriteLine("Goal added successfully.");
                break;
            case 2:
                Console.WriteLine("Please select an activity:");
                Console.WriteLine("1. Reading Scriptures");
                Console.WriteLine("2. Attending Church");
                Console.WriteLine("3. Temple Visit");
                Console.WriteLine("4. Family History");
                Console.WriteLine("5. Service Activity");

                string activityInput = Console.ReadLine();
                int activityOption;
                if (!int.TryParse(activityInput, out activityOption) || activityOption < 1 || activityOption > 5)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    continue;
                }

                Console.Write("Enter activity name: ");
                string activityName = Console.ReadLine();
                Console.Write("Enter activity description: ");
                string activityDescription = Console.ReadLine();
                Console.Write("Enter point value: ");
                int pointValue;
                if (!int.TryParse(Console.ReadLine(), out pointValue))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (activityOption)
                {
                    case 1:
                        Console.Write("Enter pages read: ");
                        int pagesRead;
                        if (!int.TryParse(Console.ReadLine(), out pagesRead))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }
                        ReadingScriptures readingScriptures = new ReadingScriptures(activityName, activityDescription, pointValue, pagesRead);
                        gameManager.AddCompletedActivity(readingScriptures);
                        Console.WriteLine("Activity added successfully.");
                        break;
                    case 2:
                        Console.Write("Enter date (format: MM/DD/YYYY): ");
                        DateTime date;
                        if (!DateTime.TryParse(Console.ReadLine(), out date))
                        {
                            Console.WriteLine("Invalid input. Please enter a date in the format MM/DD/YYYY.");
                            continue;
                        }
                        AttendingChurch attendingChurch = new AttendingChurch(activityName, activityDescription, pointValue, date);
                        gameManager.AddCompletedActivity(attendingChurch);
                        Console.WriteLine("Activity added successfully.");
                        break;
                    case 3:
                        Console.Write("Enter temple name: ");
                        string templeName = Console.ReadLine();
                        TempleVisit templeVisit = new TempleVisit(activityName, activityDescription, pointValue, templeName);
                        gameManager.AddCompletedActivity(templeVisit);
                        Console.WriteLine("Activity added successfully.");
                        break;
                    case 4:
                        Console.Write("Enter number of names added: ");
                        int namesAdded;
                        if (!int.TryParse(Console.ReadLine(), out namesAdded))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }
                        FamilyHistory familyHistory = new FamilyHistory(activityName, activityDescription, pointValue, namesAdded);
                        gameManager.AddCompletedActivity(familyHistory);
                        Console.WriteLine("Activity added successfully.");
                        break;
                    case 5:
                        Console.Write("Enter hours spent: ");
                        int hoursSpent;
                        if (!int.TryParse(Console.ReadLine(), out hoursSpent))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }
                        ServiceActivity serviceActivity = new ServiceActivity(activityName, activityDescription, pointValue, hoursSpent);
                        gameManager.AddCompletedActivity(serviceActivity);
                        Console.WriteLine("Activity added successfully.");
                        break;
                }
                break;
            case 3:
                Console.WriteLine("Completed goals:");
                List<Goal> completedGoals = gameManager.GetCompletedGoals();
                if (completedGoals.Count == 0)
                {
                    Console.WriteLine("No completed goals.");
                }
                else
                {
                    foreach (Goal goal in completedGoals)
                    {
                        Console.WriteLine(goal.GetName());
                    }
                }
                break;
            case 4:
                int score = gameManager.GetScore();
                Console.WriteLine("Score: " + score);
                break;
            case 5:
                isRunning = false;
                break;
            default:
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                break;
        }
    }
}
}
