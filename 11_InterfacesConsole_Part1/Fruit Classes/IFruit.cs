using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_InterfacesConsole_Part1.Fruit_Classes
{
    public interface IFruit
    {
        string Name { get; } // Property with only a GET
        bool Peeled { get; set; } // Property with a get AND a set
        string Peel(); // Method with only a return type and no parameters or business logic
    }
}
