using System;
using System.Collections.Generic;
/*When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.

Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 

Depending on the number of names provided, display a message based on the above pattern.
*/
namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter names. Press enter with no entry to quit.");
                
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
                Console.Write(names);
            }
            if (names.Capacity == 1) {
                Console.WriteLine(names[1] + "liked your post.");
            }
            else if (names.Capacity == 2) {
                Console.WriteLine(names[0] + names[1] + "liked your post.");
            }
            else if (names.Capacity > 2)
            {
                Console.WriteLine(names[0] + names[1] + " and " + (names.Capacity - 2) +  "others liked your post.");
            }
            else {
                Console.WriteLine("Noone liked your post.");
            }



        }
        }
    }

