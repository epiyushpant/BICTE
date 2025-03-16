

namespace C_Basics.Oop.Abstraction
{

    public interface IAnimal
    {
        string Name { get; set; }
        void MakeSound();
        void DisplayInfo();
    }

    public class Bird : IAnimal
    {
        public string Name { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("Bird sings: Tweet! Tweet!");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Bird: {Name}");
        }
    }

    public  class InterfaceDemo
    {
        //IAnimal bird = new Bird { Name = "Kiwi" };

        //bird.DisplayInfo();
        //    bird.MakeSound();
    }
}
