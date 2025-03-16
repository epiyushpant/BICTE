namespace C_Basics.Class.PartialClass
{
    public partial class Employee
        {
            public int EmployeeId { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? Department { get; set; }

            public void DisplayEmployeeInfo()
            {
                Console.WriteLine($"ID: {EmployeeId}, Name: {FirstName} {LastName}, Department: {Department}");
            }
        }
}
