using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Urunler
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunIsmi { get; set; }
        public double BegenilmeOrani { get; set; }
        public double Fiyat { get; set; }
        public double UretimSuresi { get; set; }

        public override string ToString()
        {
            return $"{UrunIsmi} {Fiyat} {BegenilmeOrani} {UretimSuresi}";
        }
    }
}
