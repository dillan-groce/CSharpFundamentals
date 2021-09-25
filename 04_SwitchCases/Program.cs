using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello world!");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("This is default. It will be executed if no other case is evaluated.");
                    break;
            }

            DayOfWeek today = DateTime.Today.DayOfWeek;
            switch (today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Welcome to the beginning of a work week!");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Still working!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's the weekend!!");
                    break;
            }

            //--Challenge
            //--Ask user how they're feeling on a scale of 1-5 > Capture their Input > run it through a switch statement.
            //--Output a different response for each value. If they respond out of range, let them know.

            Console.WriteLine("How are you feeling on a scale of 1-5?");
            int range=int.Parse(Console.ReadLine());
            string response = Console.ReadLine();
            switch(range){
                case 1:
                    Console.WriteLine("Oh no, I'm sorry to hear that that.");
                    break;
                case 2:
                    Console.WriteLine("Hope you get to feeling better soon!");
                    break;
                case 3:
                    Console.WriteLine("Hnag in there- you'll feel better soon.");
                    break;
                case 4:
                    Console.WriteLine("Not too shabby.");
                    break;
                case 5:
                    Console.WriteLine("Great! I'm happy to hear that!");
                    break;
                default:
                    Console.WriteLine("Sorry, you have responded out of range.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
