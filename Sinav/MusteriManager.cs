using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav
{
    public class MusteriManager : IManagerIslemleri<Musteri>
    {
        private Queue<Musteri> _musteriler = new Queue<Musteri>();

        public void Ekle(Musteri entity)
        {
            _musteriler.Enqueue(entity);
        }
        public Musteri Cikar()
        {
            if (_musteriler.Count > 0)
                return _musteriler.Dequeue();

            return null;
        }
        public List<Musteri> Listele()
        {
            return _musteriler.ToList();
        }
    }
}
