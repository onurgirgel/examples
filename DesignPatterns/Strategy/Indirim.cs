using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{

    public class Yuzde10 : IIndirim
    {
        public double Hesapla(double tutar) => tutar * 0.9;
    }
    public class Yuzde20 : IIndirim
    {
        public double Hesapla(double tutar) { return tutar * 0.8; }
    }
}
