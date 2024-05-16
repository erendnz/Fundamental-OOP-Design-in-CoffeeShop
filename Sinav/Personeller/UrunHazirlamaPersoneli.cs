using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Personeller
{
    public class UrunHazirlamaPersoneli:Personel
    {
        public void SiparisHazirla(Siparis siparis)
        {
            Thread.Sleep(Convert.ToInt32(siparis.HazirlanmaSuresi * 10));
            siparis.HazirMi = true;
        }
    }
}
