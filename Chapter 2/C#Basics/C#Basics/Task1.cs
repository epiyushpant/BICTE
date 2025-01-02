namespace C_Basics
{
    internal class Task1
    {
        internal static void FirstExercise() //Exercise 1
        {
            Console.WriteLine("==========Exercise 1===============");
            Console.Write("Please enter first number: ");
            int firstNum = int.Parse(Console.ReadLine()); //Read first number

            Console.Write("Please enter second number: ");
            int secondNum = int.Parse(Console.ReadLine()); //Read second number 

            int sum = firstNum + secondNum;
            int difference = firstNum - secondNum;
            int product = firstNum * secondNum;
            int division = firstNum / secondNum;
            int modulus = firstNum % secondNum;
            int increment = ++firstNum;
            int decrement = --secondNum;

            Console.WriteLine("Addition is:" + sum);
            Console.WriteLine("Difference is:" + difference);
            Console.WriteLine("Product is:" + product);
            Console.WriteLine("Division is:" + division);
            Console.WriteLine("Modulus is:" + modulus);
            Console.WriteLine("Increment of first number is:" + increment);
            Console.WriteLine("Decrement of second number is:" + decrement);
            Console.ReadKey();
        }
        internal static void SecondExercise() //Exercise 2
        {
            Console.WriteLine("\n\n**********Exercise 2**********");
            Console.Write("Enter first Number: ");
            int firstNum = int.Parse(Console.ReadLine());

            Console.Write("Enter second Number: ");
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("First Number > Second Number:" + (firstNum > secondNum));
            Console.WriteLine("First Number < Second Number:" + (firstNum < secondNum));
            Console.WriteLine("First Number >= Second Number:" + (firstNum >= secondNum));
            Console.WriteLine("First Number <= Second Number:" + (firstNum <= secondNum));
            Console.WriteLine("First Number == Second Number:" + (firstNum == secondNum));
            Console.WriteLine("First Number != Second Number:" + (firstNum != secondNum));

            Console.WriteLine("Both Numbers are greater than 10:" + (firstNum > 10 && secondNum > 10));
            Console.WriteLine("At least one number is even:" + (firstNum % 2 == 0 || secondNum % 2 == 0));
            Console.WriteLine("Neither number is negative:" + (firstNum >= 0 && secondNum >= 0) +"\n\n");
        }
    }
}
