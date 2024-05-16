﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav
{
    internal interface IManagerIslemleri<T> where T : class
    {
        void Ekle(T entity);
        List<T> Listele();
    }
}
