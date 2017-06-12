using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDeseni
{
    class TcKimlikSistem
    {
        public bool Kontrol(string Tc)
        {
            int uzunluk = Tc.Length;
            if (Tc[uzunluk - 1] % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
