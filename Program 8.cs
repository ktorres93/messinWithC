using System;
//4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
//If the user guesses the number, display “You won"; otherwise, display “You lost". 
//(To make sure the program is behaving correctly, you can display the secret number on the console first.
namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secret = rnd.Next(1, 11);
            Console.WriteLine(secret);


            for (int i = 4; i != 0 ; i--) {
                Console.WriteLine("Pick a number between 1 and 10.");
                var input = Convert.ToInt32(Console.ReadLine());

                    if (input == secret){
                        Console.WriteLine("you won!");
                    break;
                    }
                    if (i != 0) {
                    Console.WriteLine("you have " + (i-1) + " tries left!");
                }
            }
            Console.WriteLine("you lose :(");


        }
    }
}
