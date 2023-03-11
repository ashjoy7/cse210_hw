public class FamilyHistory : ReligiousActivity
{
    private int namesIndexed;

    public FamilyHistory(string name, string description, int pointValue, int namesIndexed)
        : base(name, description, pointValue)
    {
        this.namesIndexed = namesIndexed;
    }

    public int GetNamesIndexed()
    {
        return namesIndexed;
    }

    public override int CalculatePointValue()
    {
        // Calculate point value based on number of names indexed
        return GetNamesIndexed() / 10 * GetPointValue();
    }
}