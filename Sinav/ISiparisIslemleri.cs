using Sinav.Urunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav
{
    public interface ISiparisIslemleri
    {
        void OdemeYap(Siparis siparis);
        void SipariseUrunEkle(Siparis siparis, Urun urun);
        void SiparistenUrunCikart(Siparis siparis, Urun urun);
        void HazırSiparisleriListele();
        void SiparisiTeslimEt();
    }
}
