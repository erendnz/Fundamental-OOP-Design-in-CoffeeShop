using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Urunler.KahveCesitleri
{
    public class KahveCesitleri : Urun
    {
        public BoySecenegi Boy { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{Boy}";
        }
    }
}
