using System;

namespace CombinedProject
{
    public static class CheckPalindrome
    {
        public static void CheckAndPrint()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            input = input.ToLower();

            bool isPalindrome = true;

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    isPalindrome = false;
                    break; 
                }
            }

            if (isPalindrome)
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
