using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            DisplayMenu();
            Console.Write("\nEnter your choice (1-8, or 0 to exit): ");
            string choice = Console.ReadLine();

            if (choice == "0") break;

            switch (choice)
            {
                case "1": ReverseString(); break;
                case "2": CheckPrime(); break;
                case "3": PrintFibonacci(); break;
                case "4": FindSecondLargest(); break;
                case "5": CountVowels(); break;
                case "6": CheckArmstrong(); break;
                case "7": CheckPalindrome(); break;
                case "8": FindMissingNumber(); break;
                default: Console.WriteLine("Invalid choice!"); break;
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("=== C# Programming Assignment ===");
        Console.WriteLine("1. Reverse a String");
        Console.WriteLine("2. Check Prime Number");
        Console.WriteLine("3. Print Fibonacci Series");
        Console.WriteLine("4. Find Second Largest Number");
        Console.WriteLine("5. Count Vowels in String");
        Console.WriteLine("6. Check Armstrong Number");
        Console.WriteLine("7. Check Palindrome");
        Console.WriteLine("8. Find Missing Number");
        Console.WriteLine("0. Exit");
    }

    static void ReverseString()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        Console.WriteLine("Reversed string: " + reversed);
    }

    static void CheckPrime()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        bool isPrime = num > 1 && Enumerable.Range(2, (int)Math.Sqrt(num) - 1).All(i => num % i != 0);
        Console.WriteLine($"{num} is {(isPrime ? "" : "not ")}a prime number");
    }

    static void PrintFibonacci()
    {
        Console.Write("Enter the number of Fibonacci terms: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Fibonacci Series:");
        for (int i = 0; i < n; i++)
            Console.Write(Fibonacci(i) + " ");
        Console.WriteLine();
    }

    static int Fibonacci(int n)
    {
        if (n <= 0) return 0;
        if (n == 1) return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void FindSecondLargest()
    {
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < size; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        if (size < 2)
        {
            Console.WriteLine("Array should have at least 2 elements");
            return;
        }

        int largest = int.MinValue;
        int secondLargest = int.MinValue;
        foreach (int num in arr)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (num > secondLargest && num != largest)
                secondLargest = num;
        }
        Console.WriteLine("Second largest number: " + (secondLargest == int.MinValue ? "Not found" : secondLargest.ToString()));
    }

    static void CountVowels()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToLower();
        int vowelCount = input.Count(c => "aeiou".Contains(c));
        Console.WriteLine("Number of vowels: " + vowelCount);
    }

    static void CheckArmstrong()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int original = num;
        int sum = 0;
        int digits = num.ToString().Length;

        while (num > 0)
        {
            int digit = num % 10;
            sum += (int)Math.Pow(digit, digits);
            num /= 10;
        }
        Console.WriteLine($"{original} is {(sum == original ? "" : "not ")}an Armstrong number");
    }

    static void CheckPalindrome()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToLower();
        bool isPalindrome = input.SequenceEqual(input.Reverse());
        Console.WriteLine($"String is {(isPalindrome ? "" : "not ")}a palindrome");
    }

    static void FindMissingNumber()
    {
        Console.Write("Enter array size (N-1): ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Enter array elements (1 to N with one number missing):");
        for (int i = 0; i < size; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        int n = size + 1;
        int expectedSum = (n * (n + 1)) / 2;
        int actualSum = arr.Sum();
        Console.WriteLine("Missing number: " + (expectedSum - actualSum));
    }
}