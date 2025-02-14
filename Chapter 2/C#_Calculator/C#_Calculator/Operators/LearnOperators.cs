namespace C_Basics.Operators
{
    public class LearnOperators
    {

        /// <summary>
        /// This is a  class for learning operators 
        /// </summary>
        /// <remarks>
        /// This example shows how to use operatiors in c# 
        /// </remarks>


        public static void GetOperatorsExercise()
        {
            ///This is my console app 
            Console.WriteLine("Please enter first number!");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second  number!");
            int secondNumber = int.Parse(Console.ReadLine());


            int addedNumber = firstNumber + secondNumber;
            Console.WriteLine("Addition : " + addedNumber);


            //Task 1 complete remaining code 

            Console.ReadKey();
        }
    }
}

