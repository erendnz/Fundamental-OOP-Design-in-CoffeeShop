using Sinav.Personeller;

namespace Sinav
{
    public class KahveDukkani
    {
        public string Isim { get; set; }
        public string Lokasyon { get; set; }
        public MusteriManager Musteriler { get; set; }
        public KasaManager Kasalar { get; set; }
        public PersonelManager Personeller { get; set; }
        public TeslimNoktasi TeslimNoktasi { get; set; }

        private void KasayaMusteriAl(object sender, EventArgs e)
        {
            Kasa kasa = sender as Kasa;
            kasa.KasaDurumu = KasaDurumu.Mesgul;

            kasa.Siparis.Musteri = Musteriler.Cikar();
        }

        public void MusaitKasalaraMusteriAta()
        {
            foreach (Kasa kasa in Kasalar.Listele())
            {
                if (kasa.KasaDurumu == KasaDurumu.Musait)
                {
                    kasa.Siparis.Musteri = Musteriler.Cikar();
                    kasa.KasaDurumu = KasaDurumu.Mesgul;
                }
            }
        }
    }
}