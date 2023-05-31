using System;

class Program
{
    static void Main(string[] args)
    {
        // Print the current date and time to the console
        DateTime currentDateTime = DateTime.Now;
        Console.WriteLine("Current Date and Time: " + currentDateTime);

        // Ask the user for a number
        Console.Write("Enter a number: ");
        int hours = Convert.ToInt32(Console.ReadLine());

        // Calculate the future date and time by adding the user-entered hours
        DateTime futureDateTime = currentDateTime.AddHours(hours);

        // Print the future date and time to the console
        Console.WriteLine("Future Date and Time: " + futureDateTime);

        Console.ReadLine();
    }
}


