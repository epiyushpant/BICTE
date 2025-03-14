namespace C_Basics
{
    public class AccessInheritance
    {

        public static void GetAccessInheritance()
        {
            // Creating an object of the derived class for a full-time employee
            FullTimeEmployee ftEmployee = new FullTimeEmployee
            {
                Name = "Alice",
                Age = 30, 
                Department = "Finance",
                AnnualSalary = 75000
            };

            // Creating an object of the derived class for a part-time employee
            PartTimeEmployee ptEmployee = new PartTimeEmployee
            {
                Name = "Bob",
                Age = 25,
                Department = "Marketing",
                HourlyRate = 20,
                HoursWorked = 25
            };

            // Displaying details of the full-time employee
            ftEmployee.DisplayFullTimeInfo();
            Console.WriteLine();

            // Displaying details of the part-time employee
            ptEmployee.DisplayPartTimeInfo();

            Console.ReadLine();
        }
    }
}
