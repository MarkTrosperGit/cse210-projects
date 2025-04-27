using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        string pass;
        Console.Write("What was your grade? ");
        string string_grade = Console.ReadLine();
        int grade = int.Parse(string_grade);
        if (grade >= 90)
        {
            letter = "an A";
            pass = "did";
        }
        else if (grade >= 80)
        {
            letter = "a B";
            pass = "did";
        }
        else if (grade >= 70)
        {
            letter = "a C";
            pass = "did";
        }
        else if (grade >= 60)
        {
            letter = "a D";
            pass = "did not";
        }
        else
        {
            letter = "an f";
            pass = "did not";
        }
        Console.WriteLine($"That's {letter}. Well, you {pass} pass.");
    }
}