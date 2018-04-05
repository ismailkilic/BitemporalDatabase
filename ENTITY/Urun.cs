using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int UrunStokAdeti { get; set; }
        public double UrunFiyati { get; set; }

        public  Urun(int id, string uadi, int adet, double fiyat)
        {
            UrunID = id;
            UrunAdi = uadi;
            UrunStokAdeti = adet;
            UrunFiyati = fiyat;

        }
        public Urun()
        {


        }

    }
}
