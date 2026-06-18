
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // ------------------------------------------------------------
        // Create a list of integers
        // ------------------------------------------------------------
        List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };

        // Ask the user for a number to divide by
        Console.WriteLine("Enter a number to divide each list item by:");
        string userInput = Console.ReadLine();

        try
        {
            // Convert user input to an integer
            int divisor = Convert.ToInt32(userInput);

            // Loop through each number in the list
            foreach (int num in numbers)
            {
                // Divide the number and display the result
                int result = num / divisor;
                Console.WriteLine(num + " divided by " + divisor + " = " + result);
            }
        }
        catch (Exception ex)
        {
            // Display the error message if something goes wrong
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        // This message shows the program continued after try/catch
        Console.WriteLine("Program has continued after the try/catch block.");

        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }
}
