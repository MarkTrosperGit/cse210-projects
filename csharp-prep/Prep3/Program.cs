using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1,11);
        int Guess = 0;
        string GuessString;
        while(Guess != MagicNumber)
        {
            Console.Write("What is the magic number? ");
            GuessString = Console.ReadLine();
            Guess = int.Parse(GuessString);
            if (Guess > MagicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (Guess < MagicNumber)
            {
                Console.WriteLine("Higher");
            }
        }
        Console.WriteLine("You guessed it!");
    }
}