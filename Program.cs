using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;

namespace c_sharp_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find out the users name.
            Console.WriteLine("What is your name?");
            Console.WriteLine();

            string input = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello World! My name is " + input + "!");

            // Find out when the user started coding.
            Console.WriteLine("What year did you start developing software?");
            string startYearString = Console.ReadLine();
            Console.WriteLine();
            int startYearInt = Convert.ToInt32(startYearString);


            // Determine how long the user has been coding in years.
            DateTime localDate = DateTime.Now;
            int localDateYear = localDate.Year;
            int yearsCoding = localDateYear - startYearInt;
            Console.WriteLine("You have been coding for " + yearsCoding + " years.");
            
            // an extra lession I learned trying to do what I wanted with the date.
            // Console.WriteLine("using a number in angle braces I can call an item in the following array. ie the third item using 2 would be 3:{2}", 1, 2, 3, 4);

        }
    }
}
