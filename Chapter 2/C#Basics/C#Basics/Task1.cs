namespace C_Basics
{
    internal class Task1
    {
        internal static void Task1Exercise()
        {
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
    }
}
