public class ServiceActivity : ReligiousActivity
{
    private int hoursServed;

    public ServiceActivity(string name, string description, int pointValue, int hoursServed)
        : base(name, description, pointValue)
    {
        this.hoursServed = hoursServed;
    }

    public int GetHoursServed()
    {
        return hoursServed;
    }

    public override int CalculatePointValue()
    {
        // Calculate point value based on hours served
        return GetHoursServed() / 5 * GetPointValue();
    }
}