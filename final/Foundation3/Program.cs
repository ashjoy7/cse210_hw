class Main {
    static void Main(string[] args) {
        // Create an Address object
        Address address1 = new Address("123 Main St", "Anytown", "NY", "12345");

        // Create a Lecture object
        Lecture lecture1 = new Lecture("The Future of Technology", "A talk about emerging technologies", new DateTime(2023, 4, 15), new TimeSpan(14, 0, 0), address1, "John Smith", 50);

        // Create a Reception object
        Reception reception1 = new Reception("Networking Mixer", "A networking event for professionals", new DateTime(2023, 5, 20), new TimeSpan(18, 0, 0), address1, "rsvp@company.com");

        // Create an OutdoorGathering object
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Summer BBQ", "A fun outdoor event with food and games", new DateTime(2023, 7, 4), new TimeSpan(12, 0, 0), address1, "Sunny and warm");

        // Call each of the methods to generate marketing messages for each event
        Console.WriteLine(lecture1.GetStandardDetails());
        Console.WriteLine(lecture1.GetFullDetails());
        Console.WriteLine(lecture1.GetShortDescription());

        Console.WriteLine(reception1.GetStandardDetails());
        Console.WriteLine(reception1.GetFullDetails());
        Console.WriteLine(reception1.GetShortDescription());

        Console.WriteLine(outdoorGathering1.GetStandardDetails());
        Console.WriteLine(outdoorGathering1.GetFullDetails());
        Console.WriteLine(outdoorGathering1.GetShortDescription());
    }
}
