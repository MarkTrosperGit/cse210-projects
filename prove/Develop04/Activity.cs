
public class Activity
{
    private string _name;
    private int _duration;
    private string _description;
    protected void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
        Console.WriteLine("Get Ready...");
        Spinner(5);
    }
    protected void EndMessage()
    {
        Console.WriteLine("Well Done!");
        Spinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        Spinner(5);
    }
    protected void Spinner(int seconds)
    {
        List<string> spinnerSnaps = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (endTime > DateTime.Now)
        {
            Console.Write("\b" + spinnerSnaps[i]);
            Thread.Sleep(250);
            if (i == spinnerSnaps.Count - 1)
            {
                i = 0;
            }
            else
            {
                i++;
            }

        }
        Console.WriteLine("\b ");
    }
    // protected void CountDown()
    // {

    // }

    protected int GetDuration()
    {
        return _duration;
    }
    protected Activity(string name, int duration, string description)
    {
        _name = name;
        _duration = duration;
        _description = description;
    }
}