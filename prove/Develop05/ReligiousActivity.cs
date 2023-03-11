using System;
using System.Collections.Generic;

// Define a base class called "ReligiousActivity" that contains shared attributes such as name, description, and point value.
public abstract class ReligiousActivity
{
    private string name;
    private string description;
    private int pointValue;

    public ReligiousActivity(string name, string description, int pointValue)
    {
        this.name = name;
        this.description = description;
        this.pointValue = pointValue;
    }

    public string GetName()
    {
        return name;
    }

    public string GetDescription()
    {
        return description;
    }

    public int GetPointValue()
    {
        return pointValue;
    }

    public abstract int CalculatePointValue();
}
