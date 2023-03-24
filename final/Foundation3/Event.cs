class Event {
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address) {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetStandardDetails() {
        // Returns a string with standard event details
    }

    public string GetFullDetails() {
        // Returns a string with full event details
    }

    public string GetShortDescription() {
        // Returns a string with short event description
    }
}
