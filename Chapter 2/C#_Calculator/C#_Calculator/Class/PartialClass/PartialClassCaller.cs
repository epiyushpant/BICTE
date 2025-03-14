namespace C_Basics.Class.PartialClass
{
    public class PartialClassCaller
    {
        public static void GetPartialClass()
        {

            Employee emp = new Employee
            {
                EmployeeId = 101,
                FirstName = "John",
                LastName = "Doe",
                Department = "HR"
            };

            emp.DisplayEmployeeInfo();
            // Output: ID: 101, Name: John Doe, Department: HR

            emp.Promote();
            // Output: John Doe has been promoted.

            emp.Transfer("Finance");
            // Output: John Doe has been transferred to Finance.

        }
    }
}
