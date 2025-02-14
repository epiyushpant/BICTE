using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.Oop.Inheritance.Types.Hier
{
    public class Animal
    {
        public void Eat() { Console.WriteLine("Eating..."); }
    }

    public class Dog : Animal
    {
        public void Bark() { Console.WriteLine("Barking..."); }
    }

    public class Cat : Animal
    {
        public void Meow() { Console.WriteLine("Meowing..."); }
    }

}
