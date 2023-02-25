public class ListingActivity : MindfulnessActivity
{
    public int ListingCompletedCount { get; private set; }

    public ListingActivity(string name, string description) : base(name, description)
    {
        ListingCompletedCount = 0;
        IncrementListingActivityCount();
    }

    public override void PerformActivity()
    {
        Console.WriteLine("This activity will help you focus and clear your mind by listing items in a specific category.");
        IncrementCompletedCount();
        ListingCompletedCount++;

        Console.WriteLine("Choose a category:");
        Console.WriteLine("1. Fruits");
        Console.WriteLine("2. Animals");
        Console.WriteLine("3. Cities");
        Console.WriteLine("4. Movies");

        int categoryIndex = int.Parse(Console.ReadLine());

        string[] items = null;

        switch (categoryIndex)
        {
            case 1:
                items = new[] { "apple", "banana", "cherry", "date", "elderberry", "fig" };
                break;
            case 2:
                items = new[] { "aardvark", "bear", "cougar", "deer", "elephant", "fox" };
                break;
            case 3:
                items = new[] { "Atlanta", "Bangkok", "Cairo", "Dublin", "Edinburgh", "Florence" };
                break;
            case 4:
                items = new[] { "Avatar", "Blade Runner", "Casablanca", "Dune", "E.T.", "Fargo" };
                break;
        }

        if (items != null)
        {
            Console.WriteLine($"List all the {items.Length} items in the category '{categoryIndex}':");
            Console.WriteLine("(Type 'done' when finished)");

            int count = 1;
            foreach (var item in items)
            {
                Console.Write($"{count}. ");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "done")
                {
                    break;
                }
                else if (userInput.ToLower() == item.ToLower())
                {
                    Console.WriteLine("Correct!");
                    count++;
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
            }

            Console.WriteLine("\n\nWell done! You have completed the listing activity.");
        }
    }

    private static int listingActivityCount = 0;

    public static void IncrementListingActivityCount()
    {
        listingActivityCount++;
    }

    public static int GetListingActivityCount()
    {
        return listingActivityCount;
    }
}
