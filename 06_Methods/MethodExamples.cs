using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Methods
{
    [TestClass]
    public class MethodExamples
    {
        [TestMethod]
            public void MethodExecution()
        {
            SayHello("Dillan");
            int methodReturn = AddTwoNumbers(1, 2);
            Console.WriteLine(methodReturn);

            AddTwoNumbers(3.05, 2.56);
            AddTwoNumbers(3, 2.55); //--double value = int + duoble
            AddTwoNumbers(3.66, 1); //--double value = double + int

            AddTwoNumbers(3.0, 4);

            //--DateTime birthday = new DateTime(1892, 12, 6);
            int age = CalculateAge(new DateTime(1892, 12, 6));
            Console.WriteLine($"My age is: {age}");
        }
        //--Access Modifer (PUBLIC)
        //--Return Type (VOID)
        //--Method Signature (name) (SAYHELLO)
            //--Parameters (goes inside parenthesis)
            //--Body - the actual code in the brackets
        [TestMethod]
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello World! And Hello {name}!");
        }
        [TestMethod]
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }
        [TestMethod]
        public double AddTwoNumbers(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        [TestMethod]
        public int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            //--double floorValue = Math.Floor(totalAgeInYears)
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }
}
