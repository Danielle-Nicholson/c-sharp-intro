﻿using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // logical operators
            // OR will evalute to true is either side is true
            Console.WriteLine(true || true); // ||is OR 
            Console.WriteLine(false || true); // True
            Console.WriteLine(false || false); // False

            // AND will only evalute to TRUE if both side are TRUE
            Console.WriteLine(true && true); //True. // && is OR 
            Console.WriteLine(false && true); // False
            Console.WriteLine(false && false); // False

            // how does this behave with different data-types?
            // Console.WriteLine( true && 1 ); // it doesn't!

            // Comparative operators...
            // " Equal to" check
            Console.WriteLine(false == false); // true
            Console.WriteLine(true == false); // false
            Console.WriteLine(2.25 == 2.25); // True
            Console.WriteLine(2.25 == 3.14); // False
            // Console.WriteLine(3.14 == "3.14"); // cannot check two diff. types!!

            // "greater than" check
            Console.WriteLine(6 > 7); // False
            Console.WriteLine(10 > 5); // True

            // "less than" check
            Console.WriteLine(6 < 7); // True
            Console.WriteLine(10 < 5); // False

            //"greater-than or-equal-to" check
            Console.WriteLine(5 >= 5); // True
            Console.WriteLine(10 >= 5); // True
            Console.WriteLine(4 >= 5); // False

            //"less-than or-equal-to" check
            Console.WriteLine(5 <= 5); // True
            Console.WriteLine(10 <= 5); // False
            Console.WriteLine(4 <= 5); // True

            // "Not equal to" 
            Console.WriteLine(false != false); // false
            Console.WriteLine(true != false); // true
Console.WriteLine(5 != 5); // False
Console.WriteLine(5 != 10); // true
        }
    }
}
