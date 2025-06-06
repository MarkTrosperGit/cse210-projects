using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Assignment first = new Assignment("Mark Trosper", "Math");
        Console.WriteLine(first.GetSummary());
        MathAssignment second = new MathAssignment("John B", "Algebra", "7.3", "20.1-23.3");
        Console.WriteLine(second.GetSummary());
        Console.WriteLine(second.GetHomeworkList());
        WritingAssignment third = new WritingAssignment("Seth T", "Poetry", "Sonnet in Color");
        Console.WriteLine(third.GetSummary());
        Console.WriteLine(third.GetWritingInformation());
    }
}