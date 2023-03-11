public class ReadingScriptures : ReligiousActivity
{
    private int pagesRead;

    public ReadingScriptures(string name, string description, int pointValue, int pagesRead)
        : base(name, description, pointValue)
    {
        this.pagesRead = pagesRead;
    }

    public int GetPagesRead()
    {
        return pagesRead;
    }

    public override int CalculatePointValue()
    {
        // Calculate point value based on pages read
        return GetPagesRead() / 10 * GetPointValue();
    }
}