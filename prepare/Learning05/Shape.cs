using System;

public abstract class Shape
{
    private string color;

    public Shape(string color)
    {
        this.color = color;
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public abstract double GetArea();
}
