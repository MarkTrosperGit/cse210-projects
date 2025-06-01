using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture(1);
        string entry;
        bool run = true;
        while (run)
        {
            Console.Clear();
            scripture1.DisplayScripture();
            Console.WriteLine();
            Console.WriteLine("Press enter if you would like to hide words. Otherwise, type quit: ");
            entry = Console.ReadLine();
            if (entry == "quit")
            {
                run = false;
            }
            else
            {
                run = scripture1.HideWords();
            }
        }
        Console.WriteLine("Goodbye!");
    }
} 