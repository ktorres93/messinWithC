using System;
//2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number or okay to exit!");
            int sum = 0;
            var input = Console.ReadLine();

            while (input != "ok")
            {
                if (input == "ok")
                {
                    Convert.ToString(sum);
                    Console.WriteLine(sum);
                    break;

                }
                else
                {
                   
                    sum += Convert.ToInt32(Console.ReadLine());
                    
                }                                               
            }
        }
    }
}
