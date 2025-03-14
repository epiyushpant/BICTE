namespace C_Basics.Enums
{
    public class DemoEnum
    {
        public static  void GetEnumDemo()
        {
            // Declare a variable of type DayOfWeek
            DayOfWeek today = DayOfWeek.Sunday;

            // Display the value
            Console.WriteLine($"Today is: {today}");

            // Using enum in a switch statement
            switch (today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Let's start the week with energy!");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                    Console.WriteLine("Midweek is here, keep going!");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Almost the weekend!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Enjoy the weekend!");
                    break;
            }
        }
}
}
