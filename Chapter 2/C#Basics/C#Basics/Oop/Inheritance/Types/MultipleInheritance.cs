namespace C_Basics.Oop.Inheritance.Types.Multiple
{
    public interface IAnimal
    {
        void Eat();
    }

    public interface IPet
    {
        void Play();
    }

    public class Dog : IAnimal, IPet
    {
        public void Eat() { Console.WriteLine("Eating..."); }

        public void Play() { Console.WriteLine("Playing..."); }
    }

    public class TestMultipleInheritance
    {
        public static void GetCallInheritance()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Play();
        }
    }
}
