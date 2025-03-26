using System;
using System.Linq;

namespace CombinedProject
{
    public static class ReverseString
    {
        public static void ReverseAndPrint()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string reversed = new string(input.Reverse().ToArray());
            Console.WriteLine("Reversed string: " + reversed);
        }
    }
}