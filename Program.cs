using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 3;
            while (myNum > 0) // Iterates/loops while the condition is true
            {
                Console.WriteLine("current number is: {0}", myNum);
                myNum--;
            }
            /* For loops have 3 semi-colon-separated components:
            1) assignment
            2) [termination] condition
            3) Iteration
            */

            for (int i = 0; i < 6; i += 2)
            {
                Console.WriteLine("current (for) number is: {0}", i);
            }
            string [] myList ={ " cat", "turtle", "lizard", "frog ", "dog"};
            foreach ( string listItem in myList)
            {
                Console.WriteLine( "the current item is: {0}", listItem );
            }
        }
    }
}