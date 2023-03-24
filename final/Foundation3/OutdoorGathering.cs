class OutdoorGathering : Event {
    private string weatherStatement;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherStatement) 
        : base(title, description, date, time, address) {
        this.weatherStatement = weatherStatement;
    }

    public string GetFullDetails() {
        // Returns a string with full event details for an outdoor gathering
    }
}
