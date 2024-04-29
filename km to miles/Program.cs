using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter distance in miles:");
        if (double.TryParse(Console.ReadLine(), out double miles))
        {
            double kilometers = miles * 1.60934;
            Console.WriteLine($"{miles} miles is equal to {kilometers} kilometers.");

            double milesFromKm = kilometers / 1.60934;
            Console.WriteLine($"{kilometers} kilometers is equal to {milesFromKm} miles.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}