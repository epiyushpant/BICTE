using System;

namespace ConsoleApp.Questions
{
    public class ReverseString
    {
        public static void Run()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine("Reversed String: " + new string(charArray));
        }
    }
}