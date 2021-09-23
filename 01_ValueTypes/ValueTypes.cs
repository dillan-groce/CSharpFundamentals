using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_ValueTypes
{
    public enum PastryTypes
    {
        Cake,
        Danish,
        Croissant,
        Donut,
        Scone,
        Backlava
    }

    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void InitAndDeclareVariables()
        {
            //--Declare A Variable
            //--Declare an Integer
            int numOne;
            //--Initialize a Variable
            numOne = 1;
            //--Do it in 1 step
            int numTwo = 2;
            //--Variable=Named location in computer memory (computer memory=RAM)
            //--Difference between ValueType and ReferenceType is where it is stored
        }

        [TestMethod]
        public void ValueTypeVariables()
        {
            //--Whole Numbers
            byte byteExample = 255; //--Byte can only go from 1-255
            sbyte sByteExample = -128; //--sByte can be negative
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648; //--Minumum value of an integer
            //--"C# is a strongly-typed langauge"
            int intMax = 2147483647; //--Maximum value of an integer
            Int32 anotherIntExample = 123456;
            long longMax = 9223372036854775807; //--Maximum long value
            Int64 longMin = -9223372036854775808;

            byte byteExample2 = 76;

            //--Decimals
            double doubleExample = 1.23456789d; //--Does not need to have the 'd' suffix
            float floatExample = 1.23456789f; //--Must put 'f' suffix for float
            decimal decimalExample = 1.24567894561230m; //--Must put 'm' suffix for decimal

            Console.WriteLine(doubleExample);

            //--Character
            char charExample = 'a';
            char number = '3';
            char symbol = '&';
            char space = ' ';
            char specialChar = '\n'; //--\escape character (means you are going to put something outside the quotes?

            //--Bool is a true or false
            bool isHungry = true;
            bool isTired = false;

            //--Enum
            PastryTypes myPastry = PastryTypes.Backlava;

            //--Structs
            DateTime today = DateTime.Now;
            Console.WriteLine(today);
        }
    }
}
