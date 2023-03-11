public class AttendingChurch : ReligiousActivity
{
    private DateTime date;

    public AttendingChurch(string name, string description, int pointValue, DateTime date)
        : base(name, description, pointValue)
    {
        this.date = date;
    }

    public DateTime GetDate()
    {
        return date;
    }

    public override int CalculatePointValue()
    {
        // Fixed point value for attending church
        return GetPointValue();
    }
}