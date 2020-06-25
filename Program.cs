using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            string userInput = Console.ReadLine(); // assignment; colling data fromuser

            // we can use "if stamenty to check a condition
            // if the "if statment" is true , its code block (marked by curly braces {} will execute)
           
            if (userInput.Length > 0)

            {
                Console.WriteLine("the user entered a value.");
            } // if there is an "else" statment proceeding and "if", 
            //it will only execute ifd the " if statement " was false
            else
            {
                Console.WriteLine("the user did not enter a value.");
            }
        }
    }
}