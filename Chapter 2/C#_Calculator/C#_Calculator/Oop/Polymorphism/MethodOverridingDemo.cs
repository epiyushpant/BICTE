namespace C_Basics.Oop.Polymorphism
{
    public class Animal
    {
        // Virtual method in the base class
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    public class Dog : Animal
    {
        // Overriding the virtual method in the derived class
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    public class Cat : Animal
    {
        // Overriding the virtual method in the derived class
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    
    }
    
    public class MethodOverridingDemo
    {
        public static void GetOverloading() {

            Animal myDog = new Dog(); // Upcasting
            Animal myCat = new Cat(); // Upcasting

            // Calling the overridden methods
            myDog.MakeSound(); // Outputs "Dog barks"
            myCat.MakeSound(); // Outputs "Cat meows"
        }
    }
}
