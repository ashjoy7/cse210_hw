using System;
using System.Collections.Generic;

class ProgramClass
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create at least one activity of each type
        Running running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        activities.Add(running);

        StationaryBicycle stationaryBicycle = new StationaryBicycle(new DateTime(2022, 11, 3), 30, 25.0);
        activities.Add(stationaryBicycle);

        Swimming swimming = new Swimming(new DateTime(2022, 11, 3), 30, 10);
        activities.Add(swimming);

        // Iterate through the list and call the GetSummary method on each item and display the results
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
