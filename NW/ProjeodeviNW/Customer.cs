using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeodeviNW
{
    public class Customer
    {
        public int id;
        public string adSoyad;
        public string adres;
        public List<Order> sepet=new List<Order>();
        public Odeme o;
        public string type="";
    }
}
