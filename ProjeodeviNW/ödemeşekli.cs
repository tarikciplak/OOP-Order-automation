using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeodeviNW
{
    public partial class ödemeşekli : Form
    {
        Customer c;
        public ödemeşekli(Customer c)
        {
            this.c = c;
            InitializeComponent();
            lblAd.Text = c.adSoyad;
        }

      

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupControl2.Visible = false;
                groupControl1.Visible = false;
            }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) || (int)e.KeyChar == 8)

            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

     
        

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) {
                groupControl1.Visible = true;
                groupControl2.Visible = false;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                groupControl2.Visible = true;
                groupControl1.Visible = false;
                groupControl2.Location = new Point(47, 142);
            }

        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            
                textBox7.Text = "";
            
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void onayla_Click(object sender, EventArgs e)
        {
            if( radioButton1.Checked== true)
            {
                Kredi nesne = new Kredi();
                nesne.KrediNo = textBox2.Text;
                nesne.KartTipi = textBox3.Text;
                nesne.ExpDate = textBox4.Text.ToString();                
                c.o = nesne;
                c.type = "KREDİ";
            }
            else if(radioButton3.Checked == true)
            {
                Cek nesne = new Cek();
                nesne.Ad = textBox7.Text;
                nesne.BankaId = textBox5.Text;
                c.o = nesne;
                c.type = "ÇEK";
            }
            else
            {
                c.type = "NAKİT";
            }
            c.adres= textBox1.Text;
            SqlConnection con = new SqlConnection("Data Source=OWL\\TARIKOWL;Initial Catalog='Nayt story';Integrated Security=True");
            foreach (Order item in c.sepet)
            {
                con.Open();               
                SqlCommand da = new SqlCommand("insert into Alimlar (AlanKişi,Alinan,adet,KargoDurum,ÖdemeType,Adres,date) values ('" + c.adSoyad+"','"+item.slist[0].ürün.id +"','"+item.slist[0].adet+"','Kargonuz Teslim Aşamasındadır','"+c.type+"','"+c.adres+ "','" +DateTime.Today.ToString()+ "')", con);
                da.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Sipariş işlemi gerçekleştirildi.");            
            c.sepet.Clear();
            this.Close();

        }

        
    }
}
