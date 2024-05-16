using Sinav.Urunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav
{
    public class Siparis
    {
        public int SiparisNo { get; set; }
        
        public Musteri Musteri { get; set; }
        public List<Urun> SiparisVerilenUrunler { get; set; }
        public OdemeSecenegi OdemeSecenegi { get; set; }
        public bool OdemeYapildiMi { get; set; } = false;
        public bool HazirMi { get; set; } = false;

        public bool TeslimAlindiMi { get; set; } = false;

        public double SiparisUcreti
        {
            get
            {
                double toplam = 0;
                foreach (Urun urun in SiparisVerilenUrunler)
                {
                    toplam += urun.Fiyat;
                }
                return toplam;
            }
        }
        public double HazirlanmaSuresi {
            get
            {
                double toplamSure = 0;
                foreach (Urun urun in SiparisVerilenUrunler)
                {
                    toplamSure += urun.UretimSuresi;
                }
                return toplamSure;
            }
        }

        public override string ToString()
        {
            return $"{SiparisNo} {Musteri} {SiparisVerilenUrunler} {SiparisUcreti} {OdemeSecenegi} {HazirlanmaSuresi}" +
                $"{HazirMi} {OdemeYapildiMi} {TeslimAlindiMi}";
        }
    }
}
