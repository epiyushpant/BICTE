using System;

namespace CombinedProject
{
    public static class CheckArmstrong
    {
        public static void CheckAndPrint()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int original = number;
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit * digit * digit;
                number /= 10;
            }

            if (sum == original)
            {
                Console.WriteLine($"{original} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{original} is not an Armstrong number.");
            }
        }
    }
}