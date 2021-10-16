using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_InterfacesConsole_Part2.Interfaces
{
    public interface IRental
    {
        int RentalID { get; set; }
        decimal PricePerDay { get; set; }
        string CurrentRenter { get; set; }
    }
}
