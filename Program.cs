﻿using System;

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
    
            Console.WriteLine("Hello " + myName!);
        }
    }
}