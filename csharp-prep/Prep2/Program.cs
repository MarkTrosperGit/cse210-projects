using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade? ");
        string string_grade = Console.ReadLine();
        int grade = int.Parse(string_grade);
        if (grade >= 90)
        {
            Console.WriteLine("You got an A.");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You got an B.");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You got an C.");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You got an D.");
        }
        else
        {
            Console.WriteLine("You got an F.");
        }
        if (grade >= 70)
        {
            Console.WriteLine("That's a passing grade.");
        }
        else if (grade < 70)
        {
            Console.WriteLine("That is not a passing grade.");
        }
    }
}