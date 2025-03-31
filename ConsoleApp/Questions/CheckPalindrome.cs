using System;

namespace ConsoleApp.Questions
{
    public class CheckPalindrome
    {
        public static void Run()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Check if the string is a palindrome
            bool isPalindrome = IsPalindrome(input);
            Console.WriteLine(isPalindrome ? $"{input} is a palindrome." : $"{input} is not a palindrome.");
        }
        private static bool IsPalindrome(string str)
        {
            int left = 0, right = str.Length - 1;

            while (left < right)
            {
                if (char.ToLower(str[left]) != char.ToLower(str[right])) // Case-insensitive comparison
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}