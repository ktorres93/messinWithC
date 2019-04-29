using System;
//Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int length = 100;
            int counter = 0;
            for (int i = 0; i < length; i++)
            {
                if (i % 3 == 0)
                {
                    ++counter;

                }
                else {
                    continue;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
