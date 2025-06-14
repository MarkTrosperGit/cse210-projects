using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        bool menu = true;
        while (menu)
        {
            Console.Write("Menu Options:\n    1. Start breathing activity\n    2. Start reflecting activity\n    3. Start listing activity\n    4. Quit\nSelect a choice from the menu: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Breathing breath = new Breathing("Breathing Activity", -1, "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breath.Display();
                    break;
                case "2":
                    Reflect Refl = new Reflect("Reflection Activity", -1, "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    Refl.Display();
                    break;
                case "3":
                    Listing list = new Listing("Breathing Activity", 5, "This activity will help you reflect on the things in your life by having you list as many things as you can in a certain area.");
                    list.Display();
                    break;
                case "4":
                    menu = false;
                    Console.WriteLine($"{choice}");
                    break;
                default:
                    Console.WriteLine($"{choice}");
                    break;
            }
        }
    }
}