public class Circle : Shape
{
    private double radius;

    public Circle(string color, double radius) : base(color)
    {
        this.radius = radius;
    }

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}