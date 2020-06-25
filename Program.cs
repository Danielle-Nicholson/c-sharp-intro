using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // "=" is the assignment operator
            // string datatype is used for text.
            string myString = "this is a string!";
            // integer datatype is used for whole numbers (no decimals)
            int myInt = 42;
            // double datatype is used for decimal point numbers.
            double myDouble = 33.666;
            //Boolean is 
            bool myBool = true;

            // subtraction operator is "-" (minus.)
            Console.WriteLine(myInt - 10); // 32

            // mutiplication operator is "*" (mulitply)
            Console.WriteLine(myInt * 2); // 84

            //Division operator is "/" (division)
            Console.WriteLine(myInt / 2); // 21

            // modulus operator is "%" (percent sign.)
            Console.WriteLine(myInt % 13); // 3

            // addition operator is "+"
            // ***WAIT this is also the concatention operator.
            Console.WriteLine(myInt + 8); //50

            Console.WriteLine("3" + "3");// 33

            Console.WriteLine("3" + 3);//33
            Console.WriteLine(3 + 6 + "3");// 93

            // output our variable.
            Console.WriteLine(myInt); //42

            // new assignment on exisiting varibale
            myInt = myInt + 2; //44 
            Console.WriteLine(myInt); //42

            // myInt = myInt + "2"; // cant turn myInt into a string
            // we told C# that myInt would always be an int
            // Console.WriteLine(myInt); //42

            myInt++; // the same as typing: myInt + 1;
            Console.WriteLine(myInt); // 45
            myInt--;// the same as typing : myInt = myInt -1;
            Console.WriteLine(myInt); //44

            myInt += 3; // same as typing: myInt = my Int + 3;
             Console.WriteLine(myInt);// 47
             myInt -= 5 ; // same as typing: myInt = my Int + 3;
             Console.WriteLine(myInt);// 47
        }
    }
}
