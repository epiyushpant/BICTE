using System;
using System.Linq;

namespace ConsoleApp.Questions
{
    public class FindMissingNumber
    {
        public static void Run()
        {
            Console.Write("Enter numbers from 1 to N (with one missing), separated by spaces: ");
            int[] numbers = Console.ReadLine()
                                   .Split(' ')
                                   .Select(s => int.TryParse(s, out int n) ? n : (int?)null)
                                   .Where(n => n.HasValue)
                                   .Select(n => n.Value)
                                   .ToArray();

            int missingNumber = FindMissing(numbers);
            Console.WriteLine($"The missing number is: {missingNumber}");
        }
        private static int FindMissing(int[] arr)
        {
            int n = arr.Length + 1; // Since one number is missing
            int expectedSum = n * (n + 1) / 2; // Sum of first N numbers
            int actualSum = arr.Sum(); // Sum of given numbers

            return expectedSum - actualSum; // The missing number
        }
    }
}
