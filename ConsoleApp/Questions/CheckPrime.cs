using System;

namespace ConsoleApp.Questions
{
    public class CheckPrime
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Convert input to integer and check if it's a prime number
            if (int.TryParse(input, out int number))
            {
                bool isPrime = IsPrime(number);
                Console.WriteLine(isPrime ? $"{number} is a prime number." : $"{number} is not a prime number.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        private static bool IsPrime(int num)
        {
            if (num < 2) return false; // Numbers less than 2 are not prime

            // Check divisibility from 2 to num - 1
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false; // Number is divisible, so it's not prime
            }

            return true; // No divisors found, number is prime
        }
    }
}