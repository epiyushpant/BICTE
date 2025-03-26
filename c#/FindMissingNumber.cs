using System;

namespace CombinedProject
{
    public static class FindMissingNumber
    {
        public static void FindAndPrint()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int n = size + 1;
            int total = n * (n + 1) / 2;
            int sum = 0;

            foreach (var num in arr)
            {
                sum += num;
            }

            int missing = total - sum;
            Console.WriteLine($"The missing number is: {missing}");
        }
    }
}