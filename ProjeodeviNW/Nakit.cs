using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeodeviNW
{
    public class Nakit:Odeme
    {
        public Nakit()
        { }
        public double OdenecekTutar { get; set; }
        public override string OdemeBilgileri()
        {
            string odemebilgi = " ";
            odemebilgi = "Odenecek Tutar : " + OdenecekTutar.ToString();
            return odemebilgi;
        }
    }
}
