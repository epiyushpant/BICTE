using System;
using ConsoleApp.Questions;

class Program
{
    static void Main()
    {
        Console.Title = "Coding Assignment";

        while (true)
        {
            Console.WriteLine("\tEnter a number to choose a method to:\n");
            Console.WriteLine(" 1. Reverse a given string");
            Console.WriteLine(" 2. Check if a aumber is prime");
            Console.WriteLine(" 3. Print Fibonacci series");
            Console.WriteLine(" 4. Find second largest number from an array");
            Console.WriteLine(" 5. Count number of vowels in a given string");
            Console.WriteLine(" 6. Check if a given number is Armstromg number");
            Console.WriteLine(" 7. Check if a string is palindrome");
            Console.WriteLine(" 8. Find the missing number in an array");
            Console.WriteLine(" 9. Exit");
            Console.WriteLine("=================================================================");

            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ReverseString.Run();
                    break;
                case "2":
                    CheckPrime.Run();
                    break;
                case "3":
                    FibonacciSeries.Run();
                    break;
                case "4":
                    SecondLargestNumber.Run();
                    break;
                case "5":
                    CountVowels.Run();
                    break;
                case "6":
                    CheckArmstrong.Run();
                    break;
                case "7":
                    CheckPalindrome.Run();
                    break;
                case "8":
                    FindMissingNumber.Run();
                    break;
                case "9":
                    Console.WriteLine("\nExiting...");
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid choice. Please select again.");
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}