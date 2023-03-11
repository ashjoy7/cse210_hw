public class TempleVisit : ReligiousActivity
{
    private string templeName;

    public TempleVisit(string name, string description, int pointValue, string templeName)
        : base(name, description, pointValue)
    {
        this.templeName = templeName;
    }

    public string GetTempleName()
    {
        return templeName;
    }

    public override int CalculatePointValue()
    {
        // Fixed point value for visiting temple
        return GetPointValue();
    }
}