using _11_InterfacesConsole_Part2.Interfaces;
using _11_InterfacesConsole_Part2.RentalVehicles;
using _11_InterfacesConsole_Part2.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_InterfacesConsole_Part2
{
    // inheritence is used to associate its parent base class with its children classes --> For example: Animal-> Cat-> Lion
    // interfaces are simply contacts with a set of requirements
    class Program
    {
        //Inheritence:
        //1. Inheritence is not code-sharing
            //code-sharing is where we use a class or its members in other class for example: using Episode in the show class or referencing a method from one class in another class
        //2. Is a relationship --> Is a lion a cat ... is a cat an animal?
        //3. Need to share some common logic 
            //sharing just properties or method signatures is not enough.
            //if they all have completely different implementation, this would be pointless; might as well just write a brand new method
        //4. Inheritence can put you in a corner
            //When you overstretch the is-a-relationshio. So this results in very tightly coupled code.
        //5. You need to ask "what's the point?"
            //What is the value that you are creating?
            
        static void Main(string[] args)
        {
            //RentalSailBoat sb = new RentalSailBoat();
            //sb.StartEngine(); //a salboat does not have an engine -> bad code

            List<IRental> rentals = new List<IRental>();
            rentals.Add(new Truck() { RentalID = 1, CurrentRenter = "Truck Renter", TruckStyle = Vehicles.TruckType.LongBed });
            rentals.Add(new Car() { RentalID = 2, CurrentRenter = "Car Renter", CarStyle = Vehicles.CarType.Compact});
            rentals.Add(new Sailboat() { RentalID = 3, CurrentRenter = "Sailboat Renter", SailBoatStyle = Vehicles.SailBoatType.Boat2 });

            foreach(IRental rental in rentals)
            {
                if(rental is Truck t)
                {
                    Console.WriteLine("The {0} rented a {1} which has a RentalID of {2}", t.CurrentRenter, t.TruckStyle, t.RentalID);
                }
                else if (rental is Car c)
                {
                    Console.WriteLine("The {0} rented a {1} which has RentalID of {2}", c.CurrentRenter, c.CarStyle, c.RentalID);
                }
                else if (rental is Sailboat sb)
                {
                    Console.WriteLine("The {0} rented a {1} which has RentalID of {2}", sb.CurrentRenter, sb.SailBoatStyle, sb.RentalID);
                    sb.NumberOfLifeJackets = 2;
                    Console.WriteLine("The " + sb.SailBoatStyle + " has " + sb.NumberOfLifeJackets + " life jackets");
                }
            }
            Console.ReadKey();
        }
    }
}
