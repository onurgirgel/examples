﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public static class YarismaSesleri
    {
        public static void AlkisSesiCikar(int alkisSayisi, int beklemeSuresi)
        {

            Thread.Sleep(beklemeSuresi);
            for (int i = 0; i < alkisSayisi; i++)
            {
                Console.Beep(800, 150);
            }
        }
    }
}
