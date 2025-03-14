using System;

namespace CombinedProject
{
    public static class CheckPalindrome
    {
        public static void CheckAndPrint()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string reversed = new string(input.Reverse().ToArray());

            if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{input} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome.");
            }
        }
    }
}