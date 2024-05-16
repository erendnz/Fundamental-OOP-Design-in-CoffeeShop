using Sinav.Personeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav
{
    public class Kasa
    {
        public int KasaNo { get; set; }
        public KasaPersoneli KasaPersoneli { get; set; }
        public Siparis Siparis { get; set; }

        KasaDurumu kasaDurumu;
        public KasaDurumu KasaDurumu
        {
            get { return kasaDurumu; }
            set
            {
                kasaDurumu = value;
                if (value == KasaDurumu.Musait)
                {

                    KasaMusait?.Invoke(this, new EventArgs());

                }
            }
        }

        public override string ToString()
        {
            return $"Kasa {KasaNo} {KasaDurumu} Personel=>{KasaPersoneli}   Siparis=>{Siparis}";
        }

        public event EventHandler KasaMusait;
    }
}
