using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursSpentStudying = 1;
            if(hoursSpentStudying < 16) //--If this line of code (in parenthesis) is true, execute what's inside of the curly braces.
            {
                Console.WriteLine("Student spent less than 16 hours studying.");
                Console.WriteLine("Another line.");
            }

            bool choresAreDone = false;
            if (choresAreDone) //--If chores are done=true, write the line below
            {
                Console.WriteLine("Woo Hoo! You are productive!");
            }
            else //--If not, run the below.
            {
                Console.WriteLine("Get to work now!");
            }

            Console.WriteLine("How old are you?");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            if (age > 17)
            {
                Console.WriteLine( "Congrats on being an adult!"); //--If my age is not greater than 17, it will read my else
            }
            else
            {
                if (age < 6)
                {
                    Console.WriteLine("You are a kiddo!"); //--If you say less than 6, you are a kiddo
                }
                else if (age < 0)
                {
                    Console.WriteLine("You are a baby!");
                }
                else
                {
                    Console.WriteLine("You are not even born!");
                }
             }
            
            Console.ReadKey();
        }
    }
}
