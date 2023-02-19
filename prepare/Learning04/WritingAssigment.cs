public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return "Title: " + _title + "\nStudent Name: " + GetStudentName();
    }

    public string GetStudentName()
    {
        return base.GetSummary().Split(" - ")[0];
    }
}
