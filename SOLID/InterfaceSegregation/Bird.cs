using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation
{
    public class Bird : ITalking, IWorking, IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying...");
        }

        public void Talk()
        {
            Console.WriteLine("Bird is talking...");
        }

        public void Work()
        {
            Console.WriteLine("Bird is working...");
        }
    }
}
