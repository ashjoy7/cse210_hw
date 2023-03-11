using System;
using System.Collections.Generic;

public class Goal
{
    private string name;
    private string description;
    private int targetCompletionCount;
    private int currentCompletionCount;

    public Goal(string name, string description, int targetCompletionCount)
    {
        this.name = name;
        this.description = description;
        this.targetCompletionCount = targetCompletionCount;
        this.currentCompletionCount = 0;
    }

    public string GetName()
    {
        return name;
    }

    public string GetDescription()
    {
        return description;
    }

    public int GetTargetCompletionCount()
    {
        return targetCompletionCount;
    }

    public int GetCurrentCompletionCount()
    {
        return currentCompletionCount;
    }

    public void IncrementCompletionCount()
    {
        currentCompletionCount++;
    }
}