namespace C_Basics.Oop.Inheritance.Types
{
    public class Animal
    {
        public void Eat() { Console.WriteLine("Eating..."); }
    }

    public class Mammal : Animal
    {
        public void Breathe() { Console.WriteLine("Breathing..."); }
    }

    public class Dog : Mammal
    {
        public void Bark() { Console.WriteLine("Barking..."); }
    }

}
