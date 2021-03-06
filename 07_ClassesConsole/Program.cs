using _07_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ClassesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle firstVehicle = new Vehicle();

            firstVehicle.Make = "Honda";
            firstVehicle.Model = "Civic";
            firstVehicle.Year = 2012;
            firstVehicle.Type = VehicleType.Car;
            firstVehicle.Mileage = 150000;
            firstVehicle.Color = "Gray";

            Vehicle secondVehicle = new Vehicle("Chevy", "Silverado", 1994, 98000, "Black", VehicleType.Truck);
            Console.WriteLine(secondVehicle.Make);
            Console.ReadLine();

            Person firstPerson = new Person("Garry", "Banks", new DateTime(1991, 08, 24), firstVehicle);
            Console.WriteLine(firstPerson.FullName);
            Console.WriteLine(firstPerson.AgeInYears);
            Console.ReadKey();

            PersonRepository repo = new PersonRepository(); //--Instance of the Person Repository class. I am creating a Person Repository Object.
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();

            repo.AddPerson(person3);









        }
    }
}
