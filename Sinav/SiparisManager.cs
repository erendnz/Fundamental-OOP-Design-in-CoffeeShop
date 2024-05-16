using Sinav.Urunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav
{
    public class SiparisManager:IManagerIslemleri<Siparis> , ISiparisIslemleri
    {
        private List<Siparis> _siparisler = new List<Siparis>();
        public Siparis Siparis { get; set; }

        public void Ekle(Siparis siparis)
        {
            _siparisler.Add(siparis);
        }

        public List<Siparis> Listele()
        {
            return _siparisler; 
        }

        public void OdemeYap(Siparis siparis)
        {
            siparis.OdemeYapildiMi = true;
        }

        public void SiparistenUrunCikart(Siparis siparis,Urun urun)
        {
            siparis.SiparisVerilenUrunler.Add(urun);
        }

        public void SipariseUrunEkle(Siparis siparis, Urun urun)
        {
            if (siparis.SiparisVerilenUrunler.Contains(urun))
            {
                siparis.SiparisVerilenUrunler.Remove(urun);
            }
        }

        public void HazırSiparisleriListele()
        {
            foreach (Siparis siparis in _siparisler)
            {
                if (siparis.HazirMi)
                {
                    TeslimNoktasi.HazirSiparisler.Add(siparis);
                }
            }
        }

        public void SiparisiTeslimEt()
        {
            foreach (Siparis siparis in TeslimNoktasi.HazirSiparisler)
            {
                if (TeslimNoktasi.BekleyenMusteriler.Contains(siparis.Musteri))
                {
                    siparis.TeslimAlindiMi = true;
                }
                TeslimNoktasi.BekleyenMusteriler.Remove(siparis.Musteri);
                TeslimNoktasi.HazirSiparisler.Remove(siparis);
            }
        }

    }
}
