using System;
//3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
//For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.


namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");
            var orignal = Convert.ToInt32(Console.ReadLine());
            var input = Convert.ToInt32(Console.ReadLine());
            var counter = input;

            while (input > 0)
            {
                if (input == 1) {
                    break;
                }
                --input;
                counter *= input;
               // Console.WriteLine("counter:" + counter);
               // Console.WriteLine("input:" + input);
            }
            Console.WriteLine( orignal +  "! " + " = " + counter);
        }
    }
}
