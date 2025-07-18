using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> list1 = new List<Activity>
        {
            new Swimming("May 17th, 2028", 15, 15),
            new Cycling("May 18th, 2028", 5, 19),
            new Running("May 19th, 2028", 7, 1)
        };
        foreach (Activity activity in list1)
        {
            Console.WriteLine(activity.GetSummary());
        }
        
    }
}