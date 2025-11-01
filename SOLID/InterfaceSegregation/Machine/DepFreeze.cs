using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation.Machine
{
    public class DepFreeze : IElectricUsing, IFreezing
    {
        public void Freeze()
        {
            Console.WriteLine("Depfreeze is freezing...");
        }

        public void UseElectric()
        {
            Console.WriteLine("Depfreeze use electric...");
        }
    }
}
