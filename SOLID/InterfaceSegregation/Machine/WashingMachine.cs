using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation.Machine
{
    public class WashingMachine : IElectricUsing, IWashing
    {
        public void UseElectric()
        {
            Console.WriteLine("Washing Machine use electric...");
        }

        public void Wash()
        {
            Console.WriteLine("Washing Machine is washing clotch...");
        }
    }
}
