using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_InterfacesConsole_Part2.RentalVehicles
{
    //Sailboats do not have engines
    public class RentalSailBoat : RentalVehicle
    {
        public override void StartEngine()
        {
            
        }
        public override void StopEngine()
        {
            
        }
    }
}
