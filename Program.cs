using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // two slashes are a single line comment 
            //We are assigning a string value to a variable.
            string myName = "Dani N";
            /* We being multi-line comments witha forward slash and asterisk. 
            
            Symbols between values or evaluations are considered "operators" 
            Below we are using the addition sysmbol to concatenate two strings.
            Concatentation means gluing two strings, or text together
            
            .... and end multi-line comments forward slash and asterisk.*/

            Console.WriteLine("Hello " + myName);
            Console.WriteLine("Please enter your name...");
                        //Assign variable 'userName' to a value entered by the user.

                        string userName = Console.ReadLine();
            Console.WriteLine("you have entered: " +userName);
            // Instead of traditional concatenation using addition operator...
            //we can use string interpolation (placeholder) to embed valies in
            //a string
            // https://docs.microsoft.com/en-us/dotnet/api/system.console.readline?view=netcore-3.1
            Console.WriteLine("hey {0}, you're looking good!", userName);

           //lets's play with strings
           Console.WriteLine("makemeuppercase".ToUpper() );
           Console.WriteLine("MAKEMELOWERCASE".ToLower() );
           // substring takes two arguments: 1. starting character positions 2. number of characters to collect.
           Console.WriteLine("ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring( 3, 3 ) );
        Console.WriteLine("XYZ".Length ); //get the number of characters for the string.
        }
    }
}
