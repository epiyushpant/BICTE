using System;

namespace CombinedProject
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("1. Reverse a String");
                Console.WriteLine("2. Check if a Number is Prime");
                Console.WriteLine("3. Print Fibonacci Series");
                Console.WriteLine("4. Find Second Largest in Array");
                Console.WriteLine("5. Count Vowels in a String");
                Console.WriteLine("6. Check if a Number is Armstrong");
                Console.WriteLine("7. Check if a String is Palindrome");
                Console.WriteLine("8. Find Missing Number in Array");
                Console.WriteLine("9. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ReverseString.ReverseAndPrint();
                        break;
                    case 2:
                        CheckPrime.CheckAndPrint();
                        break;
                    case 3:
                        FibonacciSeries.PrintSeries();
                        break;
                    case 4:
                        SecondLargest.FindAndPrint();
                        break;
                    case 5:
                        CountVowels.CountAndPrint();
                        break;
                    case 6:
                        CheckArmstrong.CheckAndPrint();
                        break;
                    case 7:
                        CheckPalindrome.CheckAndPrint();
                        break;
                    case 8:
                        FindMissingNumber.FindAndPrint();
                        break;
                    case 9:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}