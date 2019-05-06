using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    
    //Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name!");

            var input = Console.ReadLine();
            var name = input.ToCharArray();
            Array.Reverse(name);

            Console.WriteLine(name);

        }
    }
}
