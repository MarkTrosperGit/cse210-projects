using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "BYUI";
        Job job2 = new Job();
        job2._company = "UVU";
        job1._jobTitle = "Electrical Engineer";
        job1._startYear = 2025;
        job1._endYear = 2026;
        job1.Display();
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2026;
        job2._endYear = 2027;
        job2.Display();
        Resume myResume = new Resume();
        myResume._name = "Mark Trosper";
        myResume._list = [job1, job2];
        Console.WriteLine(myResume._list[0]._jobTitle);
        myResume.Display();
    }
}