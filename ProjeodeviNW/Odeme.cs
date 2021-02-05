using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeodeviNW
{
    public abstract class Odeme
    {
        public double Fiyat { get; set; }
        public Odeme()
        { }
        public abstract string OdemeBilgileri();
    }

}
