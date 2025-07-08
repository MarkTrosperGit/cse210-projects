using System;
public class Circle : Shape
{
    double _radius;
    public Circle(float radius, string color) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        double area = Math.PI * _radius * _radius;
        return Math.Round(area, 3);
    }
}