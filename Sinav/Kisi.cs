using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav
{
    public class Kisi
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public long TC { get; set; }

        public override string ToString()
        {
            return $"{Isim} {Soyisim} {TC}";
        }
    }
}
