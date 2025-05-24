using System;
using System.Formats.Asn1;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal todaysJournal = new Journal();
        Dictionary<int, string> prompts = new Dictionary<int, string>();
        prompts.Add(1,"Who was the most interesting person I interacted with today?");
        prompts.Add(2,"What was the best part of my day?");
        prompts.Add(3,"How did I see the hand of the Lord in my life today?");
        prompts.Add(4,"What was the strongest emotion I felt today?");
        prompts.Add(5,"If I had one thing I could do over today, what would it be?");
        prompts.Add(6,"Freehand:");

        Console.WriteLine("Welcome to Mark's Journal. \nIt's time to create your journal for the day! \nEnter a number below:");

        bool running = true;
        while (running)
        {
            Console.Write("\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            int menuResponse = int.Parse(Console.ReadLine());
            switch (menuResponse)
            {
                case 1:

                    Console.WriteLine("Select a Prompt:");
                    for (int n = 1; n < 7; n++)
                    {
                        Console.WriteLine($"{n}. {prompts[n]}");
                    }
                    Console.Write("Which One: ");
                    int promptResponse = int.Parse(Console.ReadLine());
                    if (promptResponse == 1 | promptResponse == 2 | promptResponse == 3 | promptResponse == 4 | promptResponse == 5 | promptResponse == 6)
                    {
                        Console.WriteLine($"{prompts[promptResponse]}");
                        Console.Write("Press Enter when you're finished: ");
                        string answer = Console.ReadLine();
                        string question = prompts[promptResponse];
                        Entry entry = new Entry(answer, question);
                        todaysJournal.AddEntry(entry);
                    }
                    else
                    {
                        break;
                    }
                    break;
                case 2:
                    if (todaysJournal._entries.Count == 0)
                    {
                        break;
                    }
                    else
                    {
                        todaysJournal.DisplayEntries();
                    }
                    break;
                case 3:
                    Console.Write("What Journal do you want to load (in file format i.e. myFile.txt): ");

                    string filereadname = Console.ReadLine();
                    
                    string[] lines = System.IO.File.ReadAllLines(filereadname);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }

                    break;
                case 4:
                    Console.Write("What Journal do you want to save (in file format i.e. myFile.txt): ");

                    string filewritename = Console.ReadLine(); ;

                    using (StreamWriter outputFile = new StreamWriter(filewritename))
                    {
                    // You can add text to the file with the WriteLine method
                    outputFile.WriteLine(todaysJournal.GetEntries());
                    }
                    break;
                case 5:
                    Console.WriteLine("");
                    running = false;
                    break;
            }
        }
    }
}