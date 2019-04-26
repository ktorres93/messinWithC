using System;

namespace ConsoleApp3
{
    //3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width:");
            var x = Console.ReadLine();
            Console.WriteLine("Enter height:");
            var y = Console.ReadLine();


            var width = Convert.ToInt32(x);

            var height = Convert.ToInt32(y);

            if (width > height)
            {
                Console.WriteLine("Tis Landscape");
            }

            else if (width < height)
            {
                Console.WriteLine("Tis portrait");
            }


            else if (width == height)
            {
                Console.WriteLine("Tis Square");
            }
            else
            {
                Console.WriteLine("what have you done...");
            }

        }
    }
}
