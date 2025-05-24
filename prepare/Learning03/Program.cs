using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a numerator: ");
        int numerator = int.Parse(Console.ReadLine());
        Console.Write("Enter a denominator: ");
        int denominator = int.Parse(Console.ReadLine());
        Fraction first = new Fraction();
        Fraction second = new Fraction(numerator);
        Fraction third = new Fraction(numerator, denominator);
        Console.WriteLine($"Using one method: {first.getNumerator()}/{first.getDenominator()}, {second.getNumerator()}/{second.getDenominator()}, & {third.getNumerator()}/{third.getDenominator()}");
        Console.WriteLine($"Using another: {first.GetFractionString()}, {second.GetFractionString()}, & {third.GetFractionString()}");
        Console.Write("Change the numerator: of the first: ");
        int firstNumerator = int.Parse(Console.ReadLine());
        first.setNumerator(firstNumerator);
        Console.Write("Change the numerator: of the second: ");
        int secondNumerator = int.Parse(Console.ReadLine());
        second.setNumerator(secondNumerator);
        Console.Write("Change the numerator: of the third: ");
        int thirdNumerator = int.Parse(Console.ReadLine());
        third.setNumerator(thirdNumerator);
        Console.WriteLine($"Using decimals: {first.GetDecimalValue()}, {second.GetDecimalValue()}, & {third.GetDecimalValue()}");
        Console.Write("Change the denominator: of the third: ");
        int thirdDenominator = int.Parse(Console.ReadLine());
        third.setDenominator(thirdDenominator);
        Console.WriteLine($"Again using decimals: {third.GetDecimalValue()}");
    }
}