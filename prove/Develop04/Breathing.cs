public class Breathing : Activity
{
    public void Display()
    {
        StartMessage();     //Begin with the description of the activity
        int duration = GetDuration();
        List<string> BoatSnaps = new List<string> { "\\~^~~~~~~~~~~~~~~*", "\\~~^~~~~~~~~~~~~~*", "\\~~~^~~~~~~~~~~~~*", "\\~~~~^~~~~~~~~~~~*", "\\~~~~~^~~~~~~~~~~*", "\\~~~~~~^~~~~~~~~~*", "\\~~~~~~~^~~~~~~~~*", "\\~~~~~~~~^~~~~~~~*", "\\~~~~~~~~~^~~~~~~*", "\\~~~~~~~~~~^~~~~~*", "\\~~~~~~~~~~~^~~~~*", "\\~~~~~~~~~~~~^~~~*", "\\~~~~~~~~~~~~~^~~*", "\\~~~~~~~~~~~~~~^~*" };
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int i = 0;
        int i2 = 0;
        string direction = "Breath in...";
        while (endTime > DateTime.Now)
        {
            Console.Clear();
            Console.Write(direction + BoatSnaps[i] + " [" + duration + "]");
            Thread.Sleep(250);
            i2++;
            if (i == BoatSnaps.Count - 1)
            {
                direction = "Now, breath out...";
            }
            else if (i == 0)
            {
                direction = "Breath in...";
            }
            if (i2 == 4) { duration--; i2 = 0 ; }
            if (direction == "Now, breath out...") { i--; }
            else { i++; }
        }
        Console.WriteLine();
        Console.WriteLine();
        EndMessage();
    }
    public Breathing(string name, int duration, string description) : base(name, duration, description)
    {
        
    }
}