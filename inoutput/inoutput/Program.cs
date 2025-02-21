using System;
namespace inoutput
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name;
            Console.Write("Enter your name :");
            name = Console.ReadLine();
            Console.Write(name);
            Console.Read();
        }
    }
}