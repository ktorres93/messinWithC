using System;
using System.Collections.Generic;
/*Write a program and ask the user to enter 5 numbers. 
* If a number has been previously entered, display an error message and ask the user to re-try. 
* Once the user successfully enters 5 unique numbers, sort them and display the result on the console. 
*/

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter unique 5 numbers!");
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                var input = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(input))
                {

                    Console.WriteLine("this number has already been used.");
                    continue;
                }

                numbers.Add(input);
            }
            numbers.Sort();
            foreach (var number in numbers)
                Console.WriteLine(number);
        }

    }

}

