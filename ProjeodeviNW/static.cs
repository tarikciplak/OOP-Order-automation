using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeodeviNW
{
    public static class Depo
    {
        public static Customer Kullanicilar = new Customer();
        public static int eindis = 0;
        public static int esayi = 0;
        public static int ksayi = 0;
        public static int kindis = 0;
        public static List<İtem> kİtem = new List<İtem>();
        public static List<İtem> eİtem = new List<İtem>();
        public static void eindisp()
        {
            eindis++;
            if ((esayi) == eindis)
            {
                eindis = 0;
            }
        }
        public static void eindisn()
        {
            eindis--;
            if (eindis == -1)
            {
                eindis = esayi - 1;
            }
        }
        public static void kindisp()
        {
            kindis++;
            if ((ksayi) == kindis)
            {
                kindis = 0;
            }
        }
        public static void kindisn()
        {
            kindis--;
            if (kindis == -1)
            {
                kindis = ksayi - 1;
            }

        }
    }
}
