internal class JournalEntry
{
    private string prompt;
    private string response;
    private DateTime now;

    public JournalEntry(string prompt, string response, DateTime now)
    {
        this.prompt = prompt;
        this.response = response;
        this.now = now;
    }

    public string Prompt { get; internal set; }
    public string Response { get; internal set; }
    public string Date { get; internal set; }
}