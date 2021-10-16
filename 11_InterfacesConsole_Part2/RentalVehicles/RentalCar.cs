using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_InterfacesConsole_Part2.RentalVehicles
{
    //A rental car is a type of rental vehicle so this works. Rental vehicle can be inherited.
    public enum CarType { Hatchback, Sedan, compact}
    public class RentalCar : RentalVehicle
    {
        public CarType CarStyle { get; set; }
    }
}
