namespace C_Basics
{
    public class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }

        // Method to display part-time employee details
        public void DisplayPartTimeInfo()
        {
            DisplayInfo(); // Calling base class method
            Console.WriteLine($"Hourly Rate: {HourlyRate}, Hours Worked: {HoursWorked}");
        }
    }
}
