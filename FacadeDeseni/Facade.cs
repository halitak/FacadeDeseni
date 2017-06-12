using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDeseni
{
    class Facade
    {
        //constructor da oluşturulabilir
        //singleton olarak tasarlanabilir

        TcKimlikSistem TcSistem = new TcKimlikSistem();
        Sistem1 Sistem1 = new Sistem1();
        Sistem2 Sistem2 = new Sistem2();

        public void Sistem2UyeEkle(string Tc)
        {
            if (TcSistem.Kontrol(Tc) && !Sistem1.KaraListeKontrol(Tc))
            {
                Sistem2.UyeEkle(Tc);
            }
        }
    }
}
