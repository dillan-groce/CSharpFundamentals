using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 7;
            int numTwo = 20;

            //--Addition
            int sum = numOne + numTwo;
            Console.WriteLine(sum);

            //--Subtraction (Integer can be a negative number-don't forget!)
            int diff = numTwo - numOne;
            Console.WriteLine(diff);

            //--Multiplication
            int product = numOne * numTwo;
            int prod = numTwo * numTwo;
            Console.WriteLine(product);
            Console.WriteLine(prod);

            //--Division
            int quotient = numTwo / numOne;
            Console.WriteLine(quotient);

            //--Remainder
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            //--TimeSpan
            DateTime today = DateTime.Now;
            DateTime someDay = new DateTime(2019, 7, 5);
            TimeSpan timeSpan = today - someDay;
            Console.WriteLine(timeSpan);

            //--Conversions
            //--Casting
            //--type name=(castType)value
            int five = 5;
            double doubleFive = (double)five;
            Console.WriteLine(doubleFive);

            char a = 'a';
            int valueA = (int)a;
            Console.WriteLine(valueA);
            Console.WriteLine(a);

            //--string myString = "This is a string.";
            //--byte myByte = (byte)myString;

            decimal myMoney = 5.87m;
            int intMoney = (int)myMoney; //5

            //--Conversion
            //type = Convert.ToType(theValue);
            int fiveTwo = 5;
            decimal decimalFive = Convert.ToDecimal(fiveTwo);

            decimal decimalTwo = 2.55m;
            int intTwo = Convert.ToInt32(decimalTwo); //3

            //--Parsing
            //type name=type.Parce(string);
            string decimalString = "5.69878";
            decimal decimalValue = decimal.Parse(decimalString);

            //--Comparison Operators
            Console.WriteLine("Enter your age.");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            Console.WriteLine("Enter in your name.");
            string userName = Console.ReadLine();

            bool equals = age == 41; //--Two equal signs means comparison. (Asking a question) One equal assigns value. (Does the left equal the right?)
            Console.WriteLine("User is 41: " + equals);
            Console.WriteLine(equals);

            bool notEquals = age != 41;
            Console.WriteLine($"User is not 41: {notEquals}");
            Console.WriteLine(notEquals);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine("Lists are equal: " + listsAreEqual);

            bool greaterThan = age > 12; //--Is age greater than 12? True or false.
            bool greaterThanOrEqual = age >= 55; //--Is age greater than or equal to 55? True or false.
            bool lessThan = age < 1; //--Is age less than 1? True or false.
            bool lessThanOrEqual = age <= 99; //--Is age less than or equal to 99? True or false.

            int numberOne = 12;
            int numberTwo = 21;
            bool orValue = equals || notEquals; //--Two pipes || means "or"

            bool tOrT = true || true;
            bool tOrF = true || false;
            bool fOrT = false || true;
            bool fOrF = false || false;

            //--For &&, both sides of the comparison have to be true in order to deliver a true bool.
            bool andValue = equals && notEquals; //--Two && symbols means "and"
            tOrT = true && true;
            tOrF = true && false;
            fOrT = false && true;
            fOrF = false && false;

            int x = 13;
            bool test = x < 44 && x > 10; //--Is x less than 44 AND is x greater than 10?
            Console.WriteLine("Yes x is less than 44 and greater than 10: " + test);

            //--For ||, only 1 side of the comparison has to be true in order to deliver a true bool.
            int y = 10;
            bool test2 = y > 20 || y < 5; //--Is y greater than 20 OR is y less than 5?
            Console.WriteLine(test2);


            Console.ReadKey();
        }
    }
}
