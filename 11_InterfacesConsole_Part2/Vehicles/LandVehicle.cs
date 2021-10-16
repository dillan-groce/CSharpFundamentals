using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_InterfacesConsole_Part2.Vehicles
{
    public class LandVehicle
    {
        public int NumberOfPassengers { get; set; }
        public void StartEngine()
        {
            Console.WriteLine("Turn key to ignition setting");
            Console.WriteLine("Turn key to on");
        }
        public void StopEngine()
        {
            Console.WriteLine("Turn key to off");
        }
    }
}
