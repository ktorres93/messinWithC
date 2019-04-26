using System;

namespace ConsoleApp2
{
    //2- Write a program which takes two numbers from the console and displays the maximum of the two.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("value for x?");
            var x = Console.ReadLine();
            var convertedX = Convert.ToInt32(x);

            Console.WriteLine("value for y?");
            var y = Console.ReadLine();
            var convertedY = Convert.ToInt32(y);
            Console.WriteLine( Math.Max(convertedX, convertedY));

        }
    }
}
