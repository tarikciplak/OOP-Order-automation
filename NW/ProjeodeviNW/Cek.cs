using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeodeviNW
{
    public class Cek:Odeme
    {
        public string Ad { get; set; }
        public string BankaId { get; set; }
        public override string OdemeBilgileri()
        {
            string odemebilgi = " ";
            odemebilgi = "Cek sahibinin veya sirketin adi : " + Ad + "\nBanka ID : " + BankaId.ToString();
            return odemebilgi;
        }
    }
}
