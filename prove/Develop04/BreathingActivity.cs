public class BreathingActivity : MindfulnessActivity
{
    public int BreathingCompletedCount { get; private set; }
    public int TimeInMinutes { get; }

    public BreathingActivity(string name, string description, int timeInMinutes) : base(name, description)
    {
        TimeInMinutes = timeInMinutes;
        BreathingCompletedCount = 0;
    }

    public override void PerformActivity()
    {
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        IncrementCompletedCount();
        BreathingCompletedCount++;

        int totalTimeInSeconds = TimeInMinutes * 60;

        ShowLoadingMessage();
        Console.WriteLine("Starting in 3 seconds...");
        System.Threading.Thread.Sleep(3000);

        for (int i = 0; i < totalTimeInSeconds; i += 2)
        {
            if (i % 4 == 0)
            {
                Console.WriteLine("Breathe in...");
            }
            else
            {
                Console.WriteLine("Breathe out...");
            }

            System.Threading.Thread.Sleep(2000);
            Console.Write($"{totalTimeInSeconds - i - 2} seconds remaining...     \r");
        }

        Console.WriteLine("\n\nWell done! You have completed the breathing activity.");
    }
}
