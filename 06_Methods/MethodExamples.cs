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
    }
}
