using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running(new DateTime(2022, 11, 03), 30, 3.0);
        activities.Add(running);

        StationaryBike stationaryBike = new StationaryBike(new DateTime(2022, 11, 03), 30, 10.0);
        activities.Add(stationaryBike);

        Swimming swimming = new Swimming(new DateTime(2022, 11, 03), 30, 10);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
