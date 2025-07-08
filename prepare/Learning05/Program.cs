using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Square(3,"red"),
            new Circle(4,"blue"),
            new Rectangle(4,5, "yellow")
        };

        Console.WriteLine($"Hello Learning05 World!");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} {shape.GetType().Name.ToLower()} is {shape.GetArea()} inches in area.");
        }
    }
}