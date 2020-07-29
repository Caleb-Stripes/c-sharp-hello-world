using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;

namespace c_sharp_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Hello World!");
            Console.WriteLine("My name is " + input + "!");

            Console.WriteLine();
            Console.WriteLine("What year did you start developing software?");
            string startYearString = Console.ReadLine();
            _ = Convert.ToInt32(startYearString);

            Console.WriteLine(startYearString);

            //string date = DateTime.UtcNow.ToString(MM-dd-yyyy);

            Console.WriteLine("using a number in angle braces I can call an item in the following array. ie the third item using 2 would be 3:{2}", 1, 2, 3, 4);

        }
    }
}
