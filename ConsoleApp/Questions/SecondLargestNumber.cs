using System;

namespace ConsoleApp.Questions
{
    public class SecondLargestNumber
    {
        public static void Run()
        {
            // Ask the user to enter numbers
            Console.Write("Enter numbers separated by spaces: ");
            string[] input = Console.ReadLine().Split(' ');

            // Convert input to an integer array
            int[] numbers = new int[input.Length];
            int count = 0;

            foreach (string num in input)
            {
                if (int.TryParse(num, out int result))
                {
                    numbers[count++] = result;
                }
            }

            // Ensure at least two valid numbers are entered
            if (count < 2)
            {
                Console.WriteLine("Please enter at least two valid numbers.");
                return;
            }

            // Call function to find the second largest number
            int secondLargest = FindSecondLargest(numbers, count);
            Console.WriteLine("The second largest number is: " + secondLargest);
        }

        /// <summary>
        /// Finds the second largest number in the given array.
        /// </summary>
        private static int FindSecondLargest(int[] arr, int length)
        {
            int largest = arr[0], secondLargest = int.MinValue;

            for (int i = 1; i < length; i++)
            {
                if (arr[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] > secondLargest && arr[i] < largest)
                {
                    secondLargest = arr[i];
                }
            }

            return secondLargest;
        }
    }
}