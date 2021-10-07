using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes
{
    public class PersonRepository
    {
        //--Bronze Challenge
        private List<Person> _listOfPeople = new List<Person>();

        public void AddPerson(Person person)
        {
            _listOfPeople.Add(person);
        }

        //--Silver Challenge
        public List<Person> ReturnListOfPeople()
        {
            return _listOfPeople;
        }

        //--Gold Challenge
        public void RemovePersonByName(string firstName)
        {
            foreach (Person p in _listOfPeople)
            {
                if (p.FirstName == firstName)
                {
                    _listOfPeople.Remove(p);
                }
            }
        }

        //--Super Gold Challenge
        public void UpdatePerson(Person oldPerson, Person newPerson)
        {
            foreach (Person p in _listOfPeople)
            {
                if (p == oldPerson)
                {
                    p.FirstName = newPerson.FirstName;
                    p.LastName = newPerson.LastName;
                    p.DateOfBirth = newPerson.DateOfBirth;


                }

            }
        }

        public bool AddAPerson(Person person)
        {
            int beforeCount = _listOfPeople.Count;
            _listOfPeople.Add(person);
            int afterCount = _listOfPeople.Count;
            if (afterCount == (beforeCount + 1))
            {
                return true;
            }
            return false;
        }
    }
}
