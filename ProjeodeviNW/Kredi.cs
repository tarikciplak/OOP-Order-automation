using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeodeviNW
{
    public class Kredi:Odeme
    {
        public string KrediNo { get; set; }
        public string KartTipi { get; set; }
        public string ExpDate { get; set; }
        public override string OdemeBilgileri()
        {
            string odemebigi = " ";
            odemebigi = "Kredi No : " + KrediNo.ToString()+ "\nKart Tipi : " + KartTipi.ToString() + "\nSon Kullanma Tarihi : " + ExpDate.ToString();
            return odemebigi;
        }
    }
}
