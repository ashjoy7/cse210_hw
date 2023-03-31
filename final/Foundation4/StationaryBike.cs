public class StationaryBike : Activity
{
    private double speedInMph;

    public StationaryBike(DateTime date, int lengthInMinutes, double speedInMph) : base(date, lengthInMinutes)
    {
        this.speedInMph = speedInMph;
    }

    public override double GetSpeed()
    {
        return speedInMph;
    }

    public override double GetPace()
    {
        return (60.0 / speedInMph);
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {speedInMph:F1} mph, Pace: {GetPace():F1} min/mile";
    }
}