using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up Console UI (CUI)
            Console.Title = "Hello World!!!";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************");
            Console.WriteLine("********** Hello World! *************");
            Console.WriteLine("*************************************");
            Console.BackgroundColor = ConsoleColor.Black;

           
            // Creating a new car using the SportsCar class
            SportsCar mycar = new SportsCar();
             
            // Display the car name on screen
            Console.WriteLine(mycar.GetPetName());
            
            // Wait for Enter key to be pressed.
            Console.ReadLine();

        }
    }
}
