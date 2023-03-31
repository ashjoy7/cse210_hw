public class Running : Activity
{
    private double distanceInMiles;

    public Running(DateTime date, int lengthInMinutes, double distanceInMiles) : base(date, lengthInMinutes)
    {
        this.distanceInMiles = distanceInMiles;
    }

    public override double GetDistance()
    {
        return distanceInMiles;
    }

    public override double GetSpeed()
    {
        return distanceInMiles / (lengthInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return (lengthInMinutes / distanceInMiles);
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {distanceInMiles:F2} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min/mile";
    }
}