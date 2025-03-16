using System;

namespace ConsoleApp.Questions
{
    public class CountVowels
    {
        public static void Run()
        {
            Console.Write("Enter a word to check vowel: ");
            string input = Console.ReadLine().ToLower(); // Convert to lowercase for easy comparison

            int vowelCount = CountVowelLetters(input);
            Console.WriteLine($"Number of vowels: {vowelCount}");
        }
        private static int CountVowelLetters(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if ("aeiou".Contains(c)) // Check if character is a vowel
                {
                    count++;
                }
            }
            return count;
        }
    }
}
