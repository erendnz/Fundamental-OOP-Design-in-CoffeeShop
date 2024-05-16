using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav
{
    public class KasaManager : IManagerIslemleri<Kasa>
    {
        private List<Kasa> _kasalar = new List<Kasa>(3); //Maksimum 3 kasa olabilir
        public void Ekle(Kasa entity)
        {
            _kasalar.Add(entity);
        }

        public List<Kasa> Listele()
        {

            return _kasalar;

        }

        public void KasaIslemi()
        {
            foreach (Kasa kasa in _kasalar)
            {
                if (kasa.KasaDurumu == KasaDurumu.Mesgul && kasa.Siparis.Musteri != null)
                {
                    if (kasa.Siparis.OdemeYapildiMi)
                    {
                        kasa.KasaDurumu = KasaDurumu.Musait;
                    }
                }
            }


        }
    }
}
