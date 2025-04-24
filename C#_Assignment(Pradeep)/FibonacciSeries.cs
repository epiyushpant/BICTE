using System;

namespace CombinedProject
{
    public static class FibonacciSeries
    {
        public static void PrintSeries()
        {
            Console.Write("Enter the number of terms: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci Series:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            Console.WriteLine();
        }

        private static int Fibonacci(int num)
        {
            if (num == 0) return 0;
            if (num == 1) return 1;
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
    }
}