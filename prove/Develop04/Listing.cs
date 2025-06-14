public class Listing : Activity
{
    private List<string> _listOfPrompts;
    // public void ResponseCounter()
    // {

    // }
    public void DisplayRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_listOfPrompts.Count);    // Get a random index
        string randomPrompt = _listOfPrompts[index];       // Get the number at that index
        Console.Write(randomPrompt);                //Display Prompt
    }
    public void Display()
    {
        StartMessage();
        int duration = GetDuration();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.Write(" --- ");
        DisplayRandomPrompt();
        Console.WriteLine(" --- ");
        Console.Write("Get Ready...5");
        for (int i = 4; i > 0; i--)
        {
            Thread.Sleep(1000);
            Console.Write($"\b{i}");
        }
        Console.WriteLine();
         Console.WriteLine();
        int items = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            items++;
        }
        Console.WriteLine($"You listed {items} items!");
        Console.WriteLine();
        EndMessage();
    }
    public Listing(string name, int duration, string description) : base(name, duration, description)
    {
        List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?,",
            "What are personal strengths of yours?,",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _listOfPrompts = prompts;
    }
}