using System;

namespace ConsoleApp4

//4- Your job is to write a pr1ogram for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. 
//Write a program that asks the user to enter the speed limit. 
//Once set, the program asks for the speed of a car. 
//If the user enters a value less than the speed limit, program should display Ok on the console.
//If the value is above the speed limit, the program should calculate the number of demerit points. 
//For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
//If the number of demerit points is above 12, the program should display License Suspended.
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Whats the speed limit?");
            var speedLimit = Console.ReadLine();
            var convertedSpeedLimit = Convert.ToInt32(speedLimit);

            Console.WriteLine("Whats the speed of the car?");
            var carSpeed = Console.ReadLine();
            var convertedCarSpeed = Convert.ToInt32(carSpeed);
            var howMuchOver = convertedCarSpeed - convertedSpeedLimit;
            var demeritPoints = howMuchOver / 5;



            if (howMuchOver > 0)
            {
                Console.WriteLine("You are " + howMuchOver + " mph over the speed limit.\nYou have received "+ demeritPoints + "demerit Points");
                if(demeritPoints> 12)
                {
                    Console.WriteLine("You lost your license");
                }
            }
            else if(howMuchOver < 0){
                Console.WriteLine("You are " +
                    "" + howMuchOver + " mph under the speed limit. \nOK!");
            }
           
            
        }
    }
}
