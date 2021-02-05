using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeodeviNW
{
    public class Order
    {
        public DateTime tarih;
        public string kargodurumu;
        public List<OrderDetail> slist = new List<OrderDetail>();

        public decimal kdvlitoplamfiyat()
        {
            decimal count=0;

            foreach(OrderDetail item in slist)
            {
                count += (item.toplamFiyat() * item.ürün.kdv) + item.toplamFiyat();

            }
            return count;
        }
        public decimal toplamagirlik()
        {
            decimal count = 0;
            foreach (OrderDetail item in slist)
            {
                count += item.toplamAgirlik();

            }
            return count;

        }

    }
}
