public class ReflectionActivity : MindfulnessActivity
{
    private int timeInMinutes;
    private List<string> prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string name, string description, int timeInMinutes) : base(name, description)
    {
        this.TimeInMinutes = timeInMinutes;
    }

    public int TimeInMinutes
    {
        get { return timeInMinutes; }
        set { timeInMinutes = value; }
    }

    public override void PerformActivity()
    {
        Console.WriteLine("This activity will help you reflect on past experiences and gain insights into your feelings and motivations.");

        IncrementCompletedCount();

        int totalTimeInSeconds = TimeInMinutes * 60;

        ShowLoadingMessage();
        Console.WriteLine($"Starting in 3 seconds... Total duration is {TimeInMinutes} minutes.");
        System.Threading.Thread.Sleep(3000);

        Random rnd = new Random();
        string currentPrompt = prompts[rnd.Next(prompts.Count)];
        string currentQuestion = questions[rnd.Next(questions.Count)];

        Console.WriteLine(currentPrompt);
        Console.ReadLine();

        for (int i = 0; i < totalTimeInSeconds; i += 15)
        {
            Console.WriteLine(currentQuestion);
            System.Threading.Thread.Sleep(15000);
        }

        Console.WriteLine("\n\nWell done! You have completed the reflection activity.");
    }
}