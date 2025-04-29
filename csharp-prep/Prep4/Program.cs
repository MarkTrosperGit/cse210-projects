using System;
using System.Collections.Generic;

Console.WriteLine("Enter a list of numbers, type 0 when finished.");
//string entryString;
int entry = -999999;
int sum = 0;
float numberOf = 0.00000000f;
float average = 0;
int largest = -9999999;
List<int> numbers = new List<int>();
while (entry != 0)
{
    Console.Write("Enter number: ");
    entry = int.Parse(Console.ReadLine());
    if (entry != 0)
    {
        numbers.Add(entry);
    }
}
foreach (int number in numbers)
{
    sum += number;
    numberOf += 1;

}
Console.WriteLine($"The sum is: {sum}");
foreach (int number in numbers)
{
    average = sum / numberOf;
}
Console.WriteLine($"The average is: {average}");
foreach (int number in numbers)
{
    if (number>=largest)
    {
        largest = number;
    }
}
Console.WriteLine($"The largest number is: {largest}");
