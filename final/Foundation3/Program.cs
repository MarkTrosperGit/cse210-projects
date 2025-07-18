using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {

        Gathering gathering = new Gathering("Youth Conference Finale", "The meeting will be firm in start and end dates for the youth to hear final thoughts from leaders and bear their testimonies with prayers and hyms and beginning and end.", "May 5th, 2027", "5pm", new Address("1204 Smith Dr", "Pearland", "TX", "USA"), "Sunny 60 degrees f");
        Lecture lecture = new Lecture("Anatomy Society: A Lecture On Why Pigs Don't Fly", "The lecture will start with a prayer and introduction right on time and end an hour after with refreshments. The lecture will be given by Professor Greg.", "May 17th, 2027", "7am", new Address("1208 Smith Dr", "Pearland", "TX", "USA"), "Professor Greg", 32);
        Reception reception = new Reception("Sara and Guy's Reception", "The theme is blue, the desert is cupcakes, and the family will arrange the memory piece", "May 32nd 2027", "4pm", new Address("1209 Smith Dr", "Pearland", "TX", "USA"));
        Console.WriteLine(gathering.GetShort());
        Console.WriteLine();
        Console.WriteLine(gathering.GetStandard());
        Console.WriteLine();
        Console.WriteLine(gathering.GetFull());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShort());
        Console.WriteLine();
        Console.WriteLine(lecture.GetStandard());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFull());
        Console.WriteLine();
        Console.WriteLine(reception.GetShort());
        Console.WriteLine();
        Console.WriteLine(reception.GetStandard());
        Console.WriteLine();
        Console.WriteLine(reception.GetFull());
        Console.WriteLine();
    }
    
}