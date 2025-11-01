using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation.Machine
{
    public interface IElectricUsing
    {
        void UseElectric();
    }
    public interface IFreezing
    {
        void Freeze();
    }

    public interface IWashing
    {
        void Wash();
    }
}
