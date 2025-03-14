namespace C_Basics.Oop.Inheritance.Level.Multi
{
    public class Animal
    {
        public void Eat() { Console.WriteLine("Eating method of Parent Class"); }
    }

    public class Dog : Animal
    {
        public void Bark() { 
            
            Console.WriteLine("Barking method of Child Class Called");
            Console.ReadLine();     
        }
    }


    public class TestSingleInheritance
    {
        public static void GetCallInheritance()
        {
            Animal animal = new Animal();
            animal.Eat();

            Console.WriteLine("Now calling from child class");

            Dog dog = new Dog();
            dog.Eat();
            dog.Bark(); 

            
        }
    }
}
