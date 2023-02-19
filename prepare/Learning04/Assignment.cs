using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return "Textbook section: " + _textbookSection + "\nProblems: " + _problems;
    }
}

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return "Title: " + _title;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("Samuel Bennett", "Multiplication", "Chapter 3", "Exercises 1-10");
        Console.WriteLine(math.GetSummary()); // Output: Samuel Bennett - Multiplication
        Console.WriteLine(math.GetHomeworkList()); // Output: Textbook section: Chapter 3\nProblems: Exercises 1-10

        WritingAssignment writing = new WritingAssignment("Emma Lee", "History", "The American Revolution");
        Console.WriteLine(writing.GetSummary()); // Output: Emma Lee - History
        Console.WriteLine(writing.GetWritingInformation()); // Output: Title: The American Revolution
    }
}
