namespace C_Basics.Oop.Polymorphism
{
    using System;

    public class MyString
    {
        public string Value { get; private set; }

        public MyString(string value)
        {
            Value = value;
        }

        // Overloading the + operator
        public static MyString operator +(MyString s1, MyString s2)
        {
            return new MyString($"[{s1.Value}] + [{s2.Value}]");
        }

        public override string ToString()
        {
            return Value;
        }
    }

   public  class OperatorOverloadingDemo
    {
        public static void GetOperatorOverloadingDemo()
        {
            MyString str1 = new MyString("Hello, ");
            MyString str2 = new MyString("World!");

            MyString result = str1 + str2;

            Console.WriteLine($"String 1: {str1}");
            Console.WriteLine($"String 2: {str2}");
            Console.WriteLine($"Result of concatenation with custom format: {result}");
        }
        }
    }
