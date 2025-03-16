using System;

namespace ConsoleApp.Questions
{
    public class CheckArmstrong
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Convert input to integer and check if it's an Armstrong number
            if (int.TryParse(input, out int number))
            {
                bool isArmstrong = IsArmstrong(number);
                Console.WriteLine(isArmstrong ? $"{number} is an Armstrong number." : $"{number} is not an Armstrong number.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        private static bool IsArmstrong(int num)
        {
            int sum = 0, temp = num, digits = num.ToString().Length;

            while (temp > 0)
            {
                int digit = temp % 10; // Extract last digit
                sum += (int)Math.Pow(digit, digits); // Add digit^digits to sum
                temp /= 10; // Remove last digit
            }

            return sum == num; // Check if sum matches the original number
        }
    }
}
