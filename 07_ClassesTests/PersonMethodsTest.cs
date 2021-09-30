using _07_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_ClassesTests
{
    [TestClass]
    public class PersonMethodsTest
    {
        [TestMethod]
        public void Test_AddPerson()
        {
            //--AAA
            //--(A)RRANGE - Setting up test data required to test our method.What do I need to test this method?
            PersonRepository _repo = new PersonRepository();
            Person person = new Person();

            //--(A)CT - Calling our method and saving what it returns (if it returns anything) to a variable.
            List<Person> localList = _repo.ReturnListOfPeople();
            int count = localList.Count;

            _repo.AddPerson(person);
            List<Person> updatedLocalList = _repo.ReturnListOfPeople();
            int newCount = updatedLocalList.Count;

            bool result = newCount == (count + 1) ? true : false;

            //--(A)SSERT - 
            Assert.IsTrue(result);

        }
    }
}
