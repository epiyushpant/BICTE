namespace C_Basics
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        // Method to display employee details
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Department: {Department}");
        }
    }
}
