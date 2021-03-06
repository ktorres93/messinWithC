﻿using System;
/*
 1- Write a program and ask the user to enter a number. The number should be between 1 to 10. 
 If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". 
 (This logic is used a lot in applications where values entered into input boxes need to be validated.)
     */
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("select a number between 1 & 10.");

            var input = Convert.ToInt32(Console.ReadLine());

            if (input > 10)
            {
                Console.WriteLine("Invalid");
            }
            else if (input < 1)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid");
            }
        }
    }
}
