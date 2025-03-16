namespace C_Basics
{

    // Derived Class for Full-Time Employees
    public class FullTimeEmployee : Employee
    {
        public double AnnualSalary { get; set; }

        // Method to display full-time employee details
        public void DisplayFullTimeInfo()
        {
            DisplayInfo(); // Calling base class method
            Console.WriteLine($"Annual Salary: {AnnualSalary}");
        }
    }
}
