using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeodeviNW
{
   public class OrderDetail
    {
        public int adet;
        public İtem ürün;

        public decimal toplamFiyat()
        {
            return Convert.ToDecimal(ürün.fiyat * adet);


        }
        public decimal toplamAgirlik()
        {
            return Convert.ToDecimal(adet * ürün.agirlik);

        }
        
    }
}
