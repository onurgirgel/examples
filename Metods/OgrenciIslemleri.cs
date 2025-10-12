using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    public class OgrenciIslemleri
    {
        //TODO: Parametresiz metod
        public void SelamVer()
        {
            Console.WriteLine("Merhaba öğrencim");
        }
        //TODO: Parametreli metod
        public void SelamVer(string ogrenci)
        {
            Console.WriteLine($"Merhaba {ogrenci}");
        }
        //TODO: Dönüş tipi olan parametresiz metod
        public int YasHesapla()
        {
            return DateTime.Now.Year - 2006;
        }
        //TODO: Dönüş tipi olan parametreli metod
        public int YasHesapla(int dogumTarihi)
        {
            return DateTime.Now.Year - dogumTarihi;
        }

        

    }
}
