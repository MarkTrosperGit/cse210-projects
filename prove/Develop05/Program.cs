using System;
using System.Formats.Asn1;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Initialize console menu
        List<Goal> GoalsSet = new List<Goal>();
        int score = 0;

        //Start overhead and menu
        bool running = true;
        while (running)
        {
            Console.WriteLine($"\nYou have {score} points.\n");
            Console.Write("Menu Options:\n    1. Create New Goal\n    2. List Goals\n    3. Save Goals\n    4. Load Goals\n    5. Record Event\n    6. Quit\nSelect a choice from the menu: ");
            int menuResponse = int.Parse(Console.ReadLine());
            switch (menuResponse)
            {
                case 1:
                    Console.Write("\nTypes of goals are:\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal\nWhat type of goal would you like to create? ");
                    int menuCreateResponse = int.Parse(Console.ReadLine());
                    switch (menuCreateResponse)
                    {
                        case 1:
                            Console.Write("What is the name of your goal? ");
                            string name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            int points = int.Parse(Console.ReadLine());
                            Simple simpleGoal = new Simple(name, description, points, false);
                            GoalsSet.Add(simpleGoal);
                            break;
                        case 2:
                            Console.Write("What is the name of your goal? ");
                            string name2 = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string description2 = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            int points2 = int.Parse(Console.ReadLine());
                            Eternal eternalGoal = new Eternal (name2, description2, points2, false);
                            GoalsSet.Add(eternalGoal);
                            break;
                        case 3:
                            Console.Write("What is the name of your goal? ");
                            string name3 = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string description3 = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            int points3 = int.Parse(Console.ReadLine());
                            Console.Write("How many times  does this goal need to be accomplished for a bonus? ");
                            int targetCount = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for completing it that many times? ");
                            int bonus = int.Parse(Console.ReadLine());                            
                            Check checkGoal = new Check (name3, description3, points3, false, 0, targetCount, bonus);
                            GoalsSet.Add(checkGoal);
                            break;
                        default:
                            break; 
                    }
                    break;
                case 2:
                    Console.WriteLine("\nThe Goals are:");
                    foreach (Goal goal in GoalsSet)
                    {
                        goal.DisplayForList();
                    }
                    Thread.Sleep(3000); 
                    break;
                case 3:
                    Console.Write("What file do you want to save (in file format i.e. myFile.txt): ");

                    string filewritename = Console.ReadLine(); ;

                    using (StreamWriter outputFile = new StreamWriter(filewritename))
                    {
                        // You can add text to the file with the WriteLine method

                        outputFile.WriteLine($"{score}");
                        foreach (Goal goal in GoalsSet)
                        {
                            outputFile.WriteLine(goal.GetSave());
                        }
                    }
                    break;
                case 4:
                    Console.Write("What file do you want to load (in file format i.e. myFile.txt): ");

                    string filereadname = Console.ReadLine();

                    string[] lines = System.IO.File.ReadAllLines(filereadname);
                    foreach (string line in lines)
                    {
                        if (line == lines[0])
                            score = int.Parse(line);
                        else
                        {
                            string[] classInfo = line.Split(":");
                            if (classInfo.Count() == 2)
                            {
                                string classDistinction = classInfo[0];
                                string[] details = classInfo[1].Split("|");
                                if (classDistinction == "Simple")
                                {
                                    string name = details[0];
                                    string description = details[1];
                                    int points = int.Parse(details[2]);
                                    bool isComplete = bool.Parse(details[3]);
                                    Simple simpleGoal = new Simple(name, description, points, isComplete);
                                    GoalsSet.Add(simpleGoal);
                                }
                                else if (classDistinction == "Eternal")
                                {
                                    string name = details[0];
                                    string description = details[1];
                                    int points = int.Parse(details[2]);
                                    bool isComplete = bool.Parse(details[3]);
                                    Eternal eternalGoal = new Eternal(name, description, points, isComplete);
                                    GoalsSet.Add(eternalGoal);
                                }
                                else if (classDistinction == "Check")
                                {
                                    string name = details[0];
                                    string description = details[1];
                                    int points = int.Parse(details[2]);
                                    bool isComplete = bool.Parse(details[3]);
                                    int timesCompleted = int.Parse(details[4]);
                                    int targetCount = int.Parse(details[5]);
                                    int bonus = int.Parse(details[6]);
                                    Check checkGoal = new Check(name, description, points, isComplete, timesCompleted, targetCount, bonus);
                                    GoalsSet.Add(checkGoal);
                                }
                                else
                                {
                                    Console.WriteLine("Something went wrong. Check for proper formatting.");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Something went wrong. Check for proper formatting.");
                                break;
                            }

                        }
                    }
                    break;
                case 5:
                    Console.WriteLine("The goals are:");
                    int i = 1;
                    foreach (Goal goal in GoalsSet)
                    {
                        Console.WriteLine($"{i}. {goal.GetName()}");
                        i++;
                    }
                    Console.Write("Which goal did you accomplish: ");
                    int accomplishSelect = int.Parse(Console.ReadLine()) - 1;
                    score += GoalsSet[accomplishSelect].RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("");
                    running = false;
                    break;
            }
        }
        // void displayGoals()
        // {

        // }
        // void showScore()
        // {

        // }
        // void showMessage()
        // {

        // }
        // void addGoal()
        // {

        // }
        // void save()
        // {
        //     Console.Write("What file do you want to save (in file format i.e. myFile.txt): ");

        //     string filewritename = Console.ReadLine(); ;

        //     using (StreamWriter outputFile = new StreamWriter(filewritename))
        //     {
        //         // You can add text to the file with the WriteLine method
        //         outputFile.WriteLine(todaysJournal.GetEntries());
        //     }
        // }
        // void load()
        // {
        //     Console.Write("What file do you want to load (in file format i.e. myFile.txt): ");

        //     string filereadname = Console.ReadLine();

        //     string[] lines = System.IO.File.ReadAllLines(filereadname);
        //     foreach (string line in lines)
        //     {
        //         Console.WriteLine(line);
        //     }
        // }
        // void recordEvent()
        // {

        // }
        // void recordEvent()
        // {

        // }
        //quit

    }
}
            // Dictionary<int, str
            // ing> prompts = new Dictionary<int, string>();
            // prompts.Add(1, "Who was the most interesting person I interacted with today?");
            // prompts.Add(2, "What was the best part of my day?");
            // prompts.Add(3, "How did I see the hand of the Lord in my life today?");
            // prompts.Add(4, "What was the strongest emotion I felt today?");
            // prompts.Add(5, "If I had one thing I could do over today, what would it be?");
            // prompts.Add(6, "Freehand:");