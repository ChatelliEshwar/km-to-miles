using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter distance in kilometers:");
        if (double.TryParse(Console.ReadLine(), out double kilometers))
        {
            double miles = kilometers * 0.621371;
            Console.WriteLine($"{kilometers} kilometers is equal to {miles} miles.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}