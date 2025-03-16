namespace C_Basics.Class.PartialClass
{
    public partial class Employee
    {
        public void Promote()
        {
            Console.WriteLine($"{FirstName} {LastName} has been promoted.");
        }

        public void Transfer(string newDepartment)
        {
            Department = newDepartment;
            Console.WriteLine($"{FirstName} {LastName} has been transferred to {Department}.");
        }
    }
}
