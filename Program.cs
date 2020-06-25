using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please tell us if you want to add,subtract or multiply: (add/subtract/multiply)");
            string userOperator = Console.ReadLine();
            // check if user typed add
            if (userOperator == "add")
            {
                Console.WriteLine("please enter the frist number:");
                // @link https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int 
                int firstNum = Int32.Parse(Console.ReadLine()); //convert to integer.
                Console.WriteLine(" please enter second numnber to add:");
                int secondNum = Int32.Parse(Console.ReadLine());
                // Calculate the result
                int result = firstNum + secondNum;
                Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, result);
            }
            else if (userOperator == "subtract")
            {
                Console.WriteLine("please enter the first number:");
                // @link https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int 
                int firstNum = Int32.Parse(Console.ReadLine()); //convert to integer.
                Console.WriteLine("please enter second numnber to subtract:");
                int secondNum = Int32.Parse(Console.ReadLine());
                // Calculate the result
                int result = firstNum - secondNum;
                Console.WriteLine("{0} - {1} = {2}", firstNum, secondNum, result);
            }
            else if ( userOperator == "multiply")
            {
               Console.WriteLine("please enter the first number:");
                // @link https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int 
                int firstNum = Int32.Parse(Console.ReadLine()); //convert to integer.
                Console.WriteLine("please enter second numnber to mulitply:");
                int secondNum = Int32.Parse(Console.ReadLine());
                // Calculate the result
                int result = firstNum * secondNum;
                Console.WriteLine("{0} * {1} = {2}", firstNum, secondNum, result); 
            }
            else
            {
                Console.WriteLine(" invalid operator entered.");
            }
        }
    }
}