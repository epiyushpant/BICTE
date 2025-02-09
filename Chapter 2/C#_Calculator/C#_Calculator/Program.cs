namespace C_Basics
{
    internal class Operators
    {
        internal static void GetOperatorsExercise()
        {
            // Welcome message
            Console.WriteLine("Welcome to the Console Calculator!");

            // Loop to allow multiple operations until the user decides to quit
            while (true)
            {
                // Prompt the user to enter the first number
                Console.WriteLine("Please enter the first number:");
                int firstNumber = int.Parse(Console.ReadLine()); // Read and parse the first number

                // Prompt the user to enter the second number
                Console.WriteLine("Please enter the second number:");
                int secondNumber = int.Parse(Console.ReadLine()); // Read and parse the second number

                // Display the available operations to the user
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.WriteLine("5 - Modulus");

                // Read the user's choice of operation
                int operation = int.Parse(Console.ReadLine());

                // Variables to store the result and operation name
                int result = 0;
                string operationName = "";

                // Use a switch statement to perform the selected operation
                switch (operation)
                {
                    case 1: // Addition
                        result = firstNumber + secondNumber;
                        operationName = "Addition";
                        break;
                    case 2: // Subtraction
                        result = firstNumber - secondNumber;
                        operationName = "Subtraction";
                        break;
                    case 3: // Multiplication
                        result = firstNumber * secondNumber;
                        operationName = "Multiplication";
                        break;
                    case 4: // Division
                        if (secondNumber != 0) // Check for division by zero
                        {
                            result = firstNumber / secondNumber;
                            operationName = "Division";
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            goto AskAgain; // Skip to asking if the user wants to continue
                        }
                        break;
                    case 5: // Modulus
                        if (secondNumber != 0) // Check for division by zero
                        {
                            result = firstNumber % secondNumber;
                            operationName = "Modulus";
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            goto AskAgain; // Skip to asking if the user wants to continue
                        }
                        break;
                    default: // Handle invalid operation selection
                        Console.WriteLine("Invalid operation selected.");
                        goto AskAgain; // Skip to asking if the user wants to continue
                }

                // Display the result of the operation
                Console.WriteLine($"{operationName} Result: {result}");

            AskAgain:
                // Ask the user if they want to perform another operation
                Console.WriteLine("Do you want to perform another operation? (Y/N):");
                string continueChoice = Console.ReadLine();

                // Check if the user wants to continue
                if (continueChoice.ToLower() == "n")
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break; // Exit the loop and end the program
                }
                else if (continueChoice.ToLower() != "y")
                {
                    Console.WriteLine("Invalid input. Exiting the program. Goodbye!");
                    break; // Exit the loop and end the program if input is invalid
                }
            }

            // Wait for the user to press a key before closing the console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    // Entry point of the program
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call the GetOperatorsExercise method to start the calculator
            Operators.GetOperatorsExercise();
        }
    }
}