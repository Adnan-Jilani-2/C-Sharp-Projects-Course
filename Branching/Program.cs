using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        
        // Prompt the user to enter the package weight
        Console.Write("Please enter the package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if the weight is too heavy
        if (weight > 50)
        {
            // If weight is greater than 50, display error and exit
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exits the program if weight is too heavy
        }

        // Prompt the user to enter the package width
        Console.Write("Please enter the package width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the package height
        Console.Write("Please enter the package height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the package length
        Console.Write("Please enter the package length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        // Check if the total dimensions are too large
        if (width + height + length > 50)
        {
            // If the total dimensions are greater than 50, display error and exit
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exits the program if dimensions are too large
        }

        // Calculate the shipping quote
        double quote = (width * height * length * weight) / 100;

        // Display the shipping quote
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!"); // Thank the user
    }
}
