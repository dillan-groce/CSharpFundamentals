using _11_InterfacesConsole_Part2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_InterfacesConsole_Part2.Vehicles
{
    public enum SailBoatType { Boat1, Boat2, Boat3, Boat4}
    public class Sailboat : IRental, IGear
    {
        public int RentalID { get; set; }
        public decimal PricePerDay { get; set; }
        public string CurrentRenter { get; set; }
        public SailBoatType SailBoatStyle { get; set; }
        public int NumberOfLifeJackets { get; set; }
    }
}
