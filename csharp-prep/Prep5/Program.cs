using System;

class Program
{
    static void Main(string[] args)
    {
        int favoriteNum;
        string name;
        int squaredNum;

        void DisplayWelcome()
        {Console.WriteLine("Welcome to the program!");}

        string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            return name;
        }

        int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            favoriteNum = int.Parse(Console.ReadLine());
            return favoriteNum;
            }

        int squareNumber(int favoriteNum)
        {
            squaredNum = favoriteNum * favoriteNum;
            return squaredNum;
        }

        void DisplayResult(string name, int squaredNum)
        {Console.WriteLine($"Brother {name}, the square of your number is {squaredNum}");}
        DisplayWelcome();
        name = PromptUserName();
        favoriteNum = PromptUserNumber();
        squaredNum = squareNumber(favoriteNum);
        DisplayResult(name, squaredNum);
}
}