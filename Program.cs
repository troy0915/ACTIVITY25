using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize total sum
            int totalSum = 0;
            string input;

            // Loop until user types "stop"
            while (true)
            {
                // Prompt user for input
                Console.Write("Enter a number (or type 'stop' to finish): ");
                input = Console.ReadLine();

                // Check if input is "stop" (case-insensitive)
                if (input.Equals("stop", StringComparison.OrdinalIgnoreCase))
                {
                    break; // Exit the loop
                }
                // Try to convert input to an integer
                if (int.TryParse(input, out int number))
                {
                    totalSum += number; // Add number to total sum
                }
                else
                {
                    // Ignore invalid input
                    Console.WriteLine("Invalid input, please enter a valid number.");
                }
            }

            // Display the total sum of valid numbers
            Console.WriteLine($"Total sum of valid numbers: {totalSum}");
        }
    }
}






