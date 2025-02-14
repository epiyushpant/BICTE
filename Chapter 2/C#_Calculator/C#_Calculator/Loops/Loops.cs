
namespace C_Basics.Loops
{
    /// <summary>
    /// A class demonstrating the use of a <c>for</c> and <c>forEach</c>loop in C#.
    /// </summary>
    public class Loops
    {
        /// <summary>
        /// Prints numbers using two different loop constructs: a for loop and a foreach loop.
        /// </summary>
        /// <param name="limit">
        /// The upper limit up to which numbers are printed in the for loop. 
        /// The for loop will print numbers from 1 to <paramref name="limit"/> in steps of 2.
        /// </param>
        /// <remarks>
        /// This method demonstrates the use of both for and foreach loops. 
        /// - The for loop increments by 2 and stops when it exceeds the limit.
        /// - The foreach loop iterates over a predefined integer array and prints each element.
        /// </remarks>
        /// <example>
        /// Example usage:
        /// <code>
        /// PrintNumbers(10);
        /// </code>
        /// Output:
        /// For Loop
        /// 1
        /// 3
        /// 5
        /// 7
        /// 9
        /// Foreach loop
        /// 1
        /// 2
        /// 3
        /// 4
        /// 5
        /// </example>
        public void PrintNumbers(int limit)
        {
            Console.WriteLine("For Loop");
            for (int i = 1; i <= limit;)
            {
                Console.WriteLine(i);
                i = i + 2;
            }

            Console.WriteLine("Foreach loop");

            int[] arr = { 1, 2, 3, 4, 5 };
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
        }

        public static void CallLoop(){
            Loops loop = new Loops();
            loop.PrintNumbers(100);
         }

    }
}
