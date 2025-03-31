using System;

namespace ConsoleApp.Questions
{
    public class ReverseString
    {
        public static void Run()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string reversedString = "";

            // Loop through the string in reverse order and build the reversed string
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString += input[i];
            }

            Console.WriteLine("Reversed String: " + reversedString);
        }
    }
}
