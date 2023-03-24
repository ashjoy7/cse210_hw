class StationaryBicycle : Activity
{
    private double _speed;

    public StationaryBicycle(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Stationary Bicycle ({_length} min): Speed {_speed:F1} kph, Pace: {GetPace():F1} min per km";
    }
}
