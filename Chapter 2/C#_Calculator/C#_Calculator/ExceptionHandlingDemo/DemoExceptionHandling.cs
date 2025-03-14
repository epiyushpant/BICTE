namespace C_Basics.ExceptionHandlingDemo
{
    internal class DemoExceptionHandling
    {

        public static void LearnExceptionHandling()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                string userInput = Console.ReadLine();

                // Attempt to parse the input as an integer
                int number = int.Parse(userInput);
                Console.WriteLine($"You entered: {number}");
 
                // Simulate a division operation
                int result = 100 / number;
                Console.WriteLine($"100 divided by {number} is: {result}");
            }
            catch (FormatException ex)
            {
                // Handle invalid input that can't be parsed to an integer
                Console.WriteLine("Error: Please enter a valid number.");
                Console.WriteLine($"Details: {ex.Message}");
            }  
            catch (DivideByZeroException ex)
            {
                // Handle division by zero
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Catch any other unhandled exceptions
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            finally
            {
                // Code in the finally block always executes
                Console.WriteLine("Thank you for using the application.");
            }
        }
    }
}
