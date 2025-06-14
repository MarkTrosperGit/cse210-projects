public class Reflect : Activity
{
    private List<string> _listOfPrompts;
    private List<string> _listOfQuestions;
    public void Display()
    {
        StartMessage();
        int duration = GetDuration();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.Write(" --- ");
        DisplayRandomPrompt();
        Console.WriteLine(" --- ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions related to the experience.");
        Console.Write("You may begin in: 5");
        for (int i = 4; i > 0; i--)
        {
            Thread.Sleep(1000);
            Console.Write($"\b{i}");
        }
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            DisplayRandomQuestion();
            Spinner(15);
        }
        Console.WriteLine();
        EndMessage();
    }
    public void DisplayRandomPrompt()
    {
        //Got some Chat GPT help to find Random class and ".next" again.
        Random rand = new Random();
        int index = rand.Next(_listOfPrompts.Count);    // Get a random index
        string randomPrompt = _listOfPrompts[index];       // Get the number at that index
        Console.Write(randomPrompt);                //Display Prompt
    }
    public void DisplayRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_listOfQuestions.Count);      // Get a random index
        string randomQuestion = _listOfQuestions[index];       // Get the number at that index
        Console.WriteLine(randomQuestion);                  // Dsiplay Question
    }

    public Reflect(string name, int duration, string description) : base(name, duration, description)
    {
        _listOfPrompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _listOfQuestions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

}
