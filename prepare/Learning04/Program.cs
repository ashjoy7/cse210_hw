using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

    Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
    Console.WriteLine(assignment.GetSummary());

    MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
    Console.WriteLine(math.GetSummary()); // Output: Roberto Rodriguez - Fractions
    Console.WriteLine(math.GetHomeworkList()); // Output: Section 7.3 Problems 8-19
 
    WritingAssignment writing = new WritingAssignment("Emma Lee", "History", "The American Revolution");
    Console.WriteLine(writing.GetSummary()); // Output: Emma Lee - History
    Console.WriteLine(writing.GetWritingInformation()); // Output: Title: The American Revolution\nStudent Name: Emma Lee

 }
}