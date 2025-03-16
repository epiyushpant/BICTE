using System;

namespace ConsoleApp.Questions
{
    public class FibonacciSeries
    {
        public static void Run()
        {
            Console.Write("Enter the number of Fibonacci terms: ");
            string input = Console.ReadLine();

            // Convert input to integer and validate
            if (int.TryParse(input, out int n) && n > 0)
            {
                Console.WriteLine("\nFibonacci Series:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(Fibonacci(i) + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
        private static int Fibonacci(int n)
        {
            if (n <= 1)
                return n; // Base case: 0 or 1
            return Fibonacci(n - 1) + Fibonacci(n - 2); // Recursive call
        }
    }
}
